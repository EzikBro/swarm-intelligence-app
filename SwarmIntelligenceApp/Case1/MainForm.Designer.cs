namespace Case1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonBegin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startNumericUpDown2 = new Case1.MyNumericUpDown();
            this.startNumericUpDown1 = new Case1.MyNumericUpDown();
            this.endNumericUpDown2 = new Case1.MyNumericUpDown();
            this.endNumericUpDown1 = new Case1.MyNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(108, 390);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(120, 44);
            this.buttonBegin.TabIndex = 1;
            this.buttonBegin.Text = "Начать";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Область поиска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(108, 336);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(120, 48);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 154);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 20;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(364, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Стартовая точка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Конечная точка";
            // 
            // startNumericUpDown2
            // 
            this.startNumericUpDown2.InterceptArrowKeys = false;
            this.startNumericUpDown2.Location = new System.Drawing.Point(229, 235);
            this.startNumericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.startNumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNumericUpDown2.Name = "startNumericUpDown2";
            this.startNumericUpDown2.Size = new System.Drawing.Size(32, 20);
            this.startNumericUpDown2.TabIndex = 8;
            this.startNumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startNumericUpDown1
            // 
            this.startNumericUpDown1.InterceptArrowKeys = false;
            this.startNumericUpDown1.Location = new System.Drawing.Point(175, 235);
            this.startNumericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.startNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNumericUpDown1.Name = "startNumericUpDown1";
            this.startNumericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.startNumericUpDown1.TabIndex = 7;
            this.startNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endNumericUpDown2
            // 
            this.endNumericUpDown2.InterceptArrowKeys = false;
            this.endNumericUpDown2.Location = new System.Drawing.Point(229, 276);
            this.endNumericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.endNumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumericUpDown2.Name = "endNumericUpDown2";
            this.endNumericUpDown2.Size = new System.Drawing.Size(32, 20);
            this.endNumericUpDown2.TabIndex = 5;
            this.endNumericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // endNumericUpDown1
            // 
            this.endNumericUpDown1.InterceptArrowKeys = false;
            this.endNumericUpDown1.Location = new System.Drawing.Point(175, 276);
            this.endNumericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.endNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumericUpDown1.Name = "endNumericUpDown1";
            this.endNumericUpDown1.Size = new System.Drawing.Size(32, 20);
            this.endNumericUpDown1.TabIndex = 2;
            this.endNumericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startNumericUpDown2);
            this.Controls.Add(this.startNumericUpDown1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.endNumericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endNumericUpDown1);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Label label1;
        private MyNumericUpDown endNumericUpDown2;
        private MyNumericUpDown endNumericUpDown1;
        private System.Windows.Forms.Button buttonUpdate;
        private MyNumericUpDown startNumericUpDown2;
        private MyNumericUpDown startNumericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

