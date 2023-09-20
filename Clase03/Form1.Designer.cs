namespace Clase03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox2 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 72);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(106, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Casado";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(32, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 153);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado Civil";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(368, 72);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(92, 34);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Viudo";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(229, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(137, 34);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Divorciado";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(125, 72);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(103, 34);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Soltero";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(32, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(243, 283);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Educacion";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(19, 221);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(132, 34);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Postgrado";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(19, 181);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(153, 34);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Universitaria";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(19, 141);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(115, 34);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Terciaria";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(19, 101);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(141, 34);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Secundaria";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 34);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Primaria";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(792, 351);
            label1.Name = "label1";
            label1.Size = new Size(43, 30);
            label1.TabIndex = 4;
            label1.Text = "Ver";
            // 
            // button1
            // 
            button1.Location = new Point(792, 250);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 5;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Green", "Red", "Blue", "White" });
            comboBox1.Location = new Point(750, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 38);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            listBox1.Location = new Point(338, 291);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 244);
            listBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 249);
            label2.Name = "label2";
            label2.Size = new Size(49, 30);
            label2.TabIndex = 8;
            label2.Text = "Pais";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(700, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 35);
            dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 166);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 10;
            label3.Text = "Nacimiento";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1062, 38);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(101, 34);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(315, 40);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 678);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}