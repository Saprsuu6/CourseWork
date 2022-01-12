namespace MyCourseWork
{
    partial class FileType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(12, 12);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(289, 212);
            this.Tree.TabIndex = 0;
            // 
            // FileType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 236);
            this.Controls.Add(this.Tree);
            this.Name = "FileType";
            this.Text = "FileType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Tree;
    }
}