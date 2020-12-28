using System;
using System.Windows.Forms;

namespace Base64Converter
{
    /// <summary>
    /// Provides the main form
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Creates a new instance of the <see cref="FormMain"/>
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when the user hits the clear button
        /// </summary>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxOutput.Clear();
        }

        /// <summary>
        /// Occurs when the user hits the copy button
        /// </summary>
        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOutput.Text))
                return;

            Clipboard.SetText(textBoxOutput.Text, TextDataFormat.Text);
        }

        /// <summary>
        /// Occurs when the user hits the close button
        /// </summary>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Occurs when the user hits the convert button
        /// </summary>
        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxInput.Text))
                return;

            textBoxOutput.Text = radioBase64Plain.Checked
                ? textBoxInput.Text.ToPlainText()
                : textBoxInput.Text.ToBase64String();
        }
    }
}
