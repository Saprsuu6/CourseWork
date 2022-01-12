using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCourseWork
{
    public partial class FileType : Form
    {
        readonly private RegistryKey myKey;

        public FileType(RegistryKey myKey)
        {
            InitializeComponent();
            this.myKey = myKey;

            Tree.Nodes.Add(GenerateTree(myKey, new TreeNode(myKey.Name))); // генерация дерева из реестра
        }

        // RegistryKey registryKey - текущий ключ
        // TreeNode treeNode - текущий корень дерева
        private TreeNode GenerateTree(RegistryKey registryKey, TreeNode treeNode)
        {
            try
            {
                string[] subKeys = registryKey.GetSubKeyNames();
                List<RegistryKey> subRegistryKeys = new List<RegistryKey>();

                string[] valuesNames = registryKey.GetValueNames();

                foreach (string subKey in subKeys)
                {
                    try
                    {
                        subRegistryKeys.Add(registryKey.OpenSubKey(subKey));
                    }
                    catch (Exception)
                    { }
                }

                foreach (string value in valuesNames)
                {
                    try
                    {
                        object obj = registryKey.GetValue(value);
                        treeNode.Nodes.Add(registryKey.Name + 
                            " Value: " + obj.ToString() + " (Type: " + obj.GetType() + ")");
                    }
                    catch (Exception)
                    { }
                }

                // key - открытый подкаталог из реестра
                // new TreeNode(key.Name)) - создание нового подузла дерева сразу-же при вызове функции
                // GenereteTree - рекурсивная функция которая возвращает новосозданный подузел
                foreach (RegistryKey key in subRegistryKeys)
                    treeNode.Nodes.Add(GenerateTree(key, new TreeNode(key.Name)));
            }
            catch (Exception)
            { }

            return treeNode; // возврат под узла
        }   
    }
}
