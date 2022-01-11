using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Microsoft.Win32;

namespace MyCourseWork
{
    public partial class MyCourseWork : Form
    {
        // readonly поля это те поля которыйе можно инициализировать либо сразу либо через конструктор 
        readonly private Timer timer = new Timer(); // новый таймер
        readonly private PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes"); // новый объект при помощи которого можно узнать информацию о RAM
        readonly private List<RegistryKey> myKeys;

        public MyCourseWork()
        {
            InitializeComponent(); // функция инициализации компонентов окна
            InitializeTimer(); // функция для инициализации таймера
            InitializeChart(); // функция для инициализации графика
            UpadteChart(); // функция для обновления графика

            myKeys = new List<RegistryKey>()
            {
                Registry.ClassesRoot, // вызов статического поля
                Registry.CurrentUser, // вызов статического поля
                Registry.LocalMachine, // вызов статического поля
                Registry.Users, // вызов статического поля
                Registry.CurrentConfig // вызов статического поля
            }; // создание массива содержимого 0-ого уровня реестра

            List<TreeNode> nodes = new List<TreeNode>(); // список корней 0-ого уровня

            GenerateTree(nodes, myKeys, null); // функция генерации дерева 

            foreach (TreeNode node in nodes) // заполнение дерева
                Tree.Nodes.Add(node);
        }

        // List<TreeNode> nodes - список куда будут сохраняться все корни реестра
        // List<RegistryKey> myKeys - список корней реестра текущего уровня
        // TreeNode node - текущий корень (дериктория)
        private void GenerateTree(List<TreeNode> nodes, List<RegistryKey> myKeys, TreeNode node)
        {
            TreeNode treeNode = null; // создани переменной ссылки в стеке типа корня

            if (myKeys != null) // если список пуст то ничего не делаем
            {
                foreach (RegistryKey key in myKeys) // перебор корней реестра
                {
                    treeNode = new TreeNode(key.Name); // создание нового корня на основе корней реестра

                    if (node != null) // если текущий корень не ноль - присваеваем ребёнка treeNode
                        node.Nodes.Add(treeNode);
                    else // в противном случае - добавляем корень к списку корней 0-ого уровня
                         // (сработает шарантированно один раз на первом вхождении в функцию)
                        nodes.Add(treeNode);

                    string[] subKyes;
                    string[] values;
                    List<RegistryKey> mySubKeys = null;

                    try // в случае ошибки на 74, 74, 76 строке программа не останавливается а переходит к следующему корню (на 99 строчку)
                    {
                        subKyes = key.GetSubKeyNames(); // список имён подпаок текущего корня
                        values = key.GetValueNames(); // список имён значений текущего корня
                        mySubKeys = new List<RegistryKey>(); // список корней текущего корня на основе их имён

                        foreach (string subKey in subKyes) // перебор имён подпапок
                        {
                            try // в случае ошибки на 82 строке программа не останавливается а переходит к следующему имени
                            {
                                mySubKeys.Add(key.OpenSubKey(subKey)); // создание корня на основе имени
                            }
                            catch (Exception) // отлавливание ошибки
                            { }
                        }

                        foreach (string value in values) // перебор имён значений корня
                        {
                            object obj = key.GetValue(value); // получем значение в виде базового типа object

                            if (obj != null) // если объект не ноль пишем значение его рядом с корнем
                                treeNode.Nodes.Add(key.Name + " Value: " + obj.ToString());
                        }
                    }
                    catch (Exception) // отлавливание ошибки
                    { }

                    GenerateTree(nodes, mySubKeys, treeNode); // рекурсивный переход к подкорням (адресс предыдущей функции остался в памяти стека т.к. выхода небыло)
                }
            }
        }

        private void InitializeChart()
        {
            FirstChart.Series.Add("Free RAM"); // добавление серии обозначения на графике 
            FirstChart.Series[0].ChartType = SeriesChartType.Column; // я выбрал колонки, потомучто линию не видно на графике 
        }

        private void InitializeTimer()
        {
            timer.Interval = 2000; // 2 чекунды срабатывает метод Tick
            timer.Tick += new EventHandler(Tick); // подписка на событие
            timer.Start(); // запуск таймера
        }

        private void UpadteChart()
        {
            float freeRAM = ramCounter.NextValue(); // возвращает значение на которое сейчас указывает 

            FirstChart.Series[0].Points.Clear(); // очистка точек перед каждым обновлением
            FirstChart.Series[0].Points.AddY(freeRAM); // добавление точки соответственно freeRAM
        }

        private void Tick(object sender, EventArgs e)
        {
            UpadteChart(); // каждые 2 секунды будет происходить обновление графика
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondGraphic secondGraphic = new SecondGraphic(timer); // создание окна
            secondGraphic.StartPosition = FormStartPosition.CenterParent; // посередине родителя
            secondGraphic.Owner = this; // определение родителя (себя)
            secondGraphic.ShowDialog(); // показываю модальное окно
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks(); // создание окна
            tasks.StartPosition = FormStartPosition.CenterParent; // посередине родителя
            tasks.Owner = this; // определение родителя (себя)
            tasks.ShowDialog(); // показываю модальное окно
        }
    }
}
