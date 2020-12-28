
namespace Base64Converter
{
    partial class FormMain
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.radioPlainBase64 = new System.Windows.Forms.RadioButton();
            this.radioBase64Plain = new System.Windows.Forms.RadioButton();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelConvert = new System.Windows.Forms.Panel();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.labelInput, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxInput, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxOutput, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.radioPlainBase64, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.radioBase64Plain, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.panelConvert, 4, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(452, 91);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInput.Location = new System.Drawing.Point(3, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(48, 29);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input:";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxInput
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxInput, 4);
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(57, 3);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(392, 23);
            this.textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxOutput, 4);
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(57, 62);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(392, 23);
            this.textBoxOutput.TabIndex = 3;
            // 
            // radioPlainBase64
            // 
            this.radioPlainBase64.AutoSize = true;
            this.radioPlainBase64.Checked = true;
            this.radioPlainBase64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPlainBase64.Location = new System.Drawing.Point(57, 32);
            this.radioPlainBase64.Name = "radioPlainBase64";
            this.radioPlainBase64.Size = new System.Drawing.Size(127, 24);
            this.radioPlainBase64.TabIndex = 4;
            this.radioPlainBase64.TabStop = true;
            this.radioPlainBase64.Text = "Plain text to Base64";
            this.radioPlainBase64.UseVisualStyleBackColor = true;
            // 
            // radioBase64Plain
            // 
            this.radioBase64Plain.AutoSize = true;
            this.radioBase64Plain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBase64Plain.Location = new System.Drawing.Point(190, 32);
            this.radioBase64Plain.Name = "radioBase64Plain";
            this.radioBase64Plain.Size = new System.Drawing.Size(127, 24);
            this.radioBase64Plain.TabIndex = 5;
            this.radioBase64Plain.Text = "Base64 to plain text";
            this.radioBase64Plain.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonClear);
            this.panelBottom.Controls.Add(this.buttonCopy);
            this.panelBottom.Controls.Add(this.buttonClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 91);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(452, 45);
            this.panelBottom.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(340, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(234, 10);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 23);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "Copy output";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(12, 10);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panelConvert
            // 
            this.panelConvert.Controls.Add(this.buttonConvert);
            this.panelConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConvert.Location = new System.Drawing.Point(334, 29);
            this.panelConvert.Margin = new System.Windows.Forms.Padding(0);
            this.panelConvert.Name = "panelConvert";
            this.panelConvert.Size = new System.Drawing.Size(118, 30);
            this.panelConvert.TabIndex = 6;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(6, 3);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 23);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 136);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Converter";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelConvert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.RadioButton radioPlainBase64;
        private System.Windows.Forms.RadioButton radioBase64Plain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelConvert;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClose;
    }
}

