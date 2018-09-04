namespace WindowsFormsApplication
{
    partial class FrmTree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nó10");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nó9", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nó12");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó11", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nó8", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nó7", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nó15");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó14", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(24, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nó10";
            treeNode1.Text = "Nó10";
            treeNode2.Name = "Nó9";
            treeNode2.Text = "Nó9";
            treeNode3.Name = "Nó12";
            treeNode3.Text = "Nó12";
            treeNode4.Name = "Nó11";
            treeNode4.Text = "Nó11";
            treeNode5.Name = "Nó8";
            treeNode5.Text = "Nó8";
            treeNode6.Name = "Nó7";
            treeNode6.Text = "Nó7";
            treeNode7.Name = "Nó15";
            treeNode7.Text = "Nó15";
            treeNode8.Name = "Nó14";
            treeNode8.Text = "Nó14";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(986, 468);
            this.treeView1.TabIndex = 0;
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 566);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTree";
            this.Text = "FrmTree";
            this.Load += new System.EventHandler(this.FrmTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}