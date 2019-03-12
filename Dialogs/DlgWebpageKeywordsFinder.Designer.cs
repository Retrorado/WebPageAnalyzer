namespace Dialogs
{
    partial class DlgWebpageKeywordsFinder
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInputData = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWebPage = new System.Windows.Forms.TableLayoutPanel();
            this.lblWebPageAddress = new System.Windows.Forms.Label();
            this.txtWebPageAddress = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.grpKeywords = new System.Windows.Forms.GroupBox();
            this.dgvKeywordOccurrences = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.tlpInputData.SuspendLayout();
            this.tlpWebPage.SuspendLayout();
            this.grpKeywords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywordOccurrences)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpInputData, 0, 0);
            this.tlpMain.Controls.Add(this.grpKeywords, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpInputData
            // 
            this.tlpInputData.ColumnCount = 2;
            this.tlpInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.67758F));
            this.tlpInputData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.32242F));
            this.tlpInputData.Controls.Add(this.tlpWebPage, 0, 0);
            this.tlpInputData.Controls.Add(this.btnAnalyze, 1, 0);
            this.tlpInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputData.Location = new System.Drawing.Point(3, 3);
            this.tlpInputData.Name = "tlpInputData";
            this.tlpInputData.RowCount = 1;
            this.tlpInputData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInputData.Size = new System.Drawing.Size(794, 39);
            this.tlpInputData.TabIndex = 0;
            // 
            // tlpWebPage
            // 
            this.tlpWebPage.ColumnCount = 2;
            this.tlpWebPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.68512F));
            this.tlpWebPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.31488F));
            this.tlpWebPage.Controls.Add(this.lblWebPageAddress, 0, 0);
            this.tlpWebPage.Controls.Add(this.txtWebPageAddress, 1, 0);
            this.tlpWebPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWebPage.Location = new System.Drawing.Point(3, 3);
            this.tlpWebPage.Name = "tlpWebPage";
            this.tlpWebPage.RowCount = 1;
            this.tlpWebPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWebPage.Size = new System.Drawing.Size(578, 33);
            this.tlpWebPage.TabIndex = 0;
            // 
            // lblWebPageAddress
            // 
            this.lblWebPageAddress.AutoSize = true;
            this.lblWebPageAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWebPageAddress.Location = new System.Drawing.Point(3, 0);
            this.lblWebPageAddress.Name = "lblWebPageAddress";
            this.lblWebPageAddress.Size = new System.Drawing.Size(101, 33);
            this.lblWebPageAddress.TabIndex = 0;
            this.lblWebPageAddress.Text = "Web page address:";
            this.lblWebPageAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWebPageAddress
            // 
            this.txtWebPageAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebPageAddress.Location = new System.Drawing.Point(110, 6);
            this.txtWebPageAddress.Name = "txtWebPageAddress";
            this.txtWebPageAddress.Size = new System.Drawing.Size(465, 20);
            this.txtWebPageAddress.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalyze.Location = new System.Drawing.Point(587, 3);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(204, 33);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "ANALYZE";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // grpKeywords
            // 
            this.grpKeywords.Controls.Add(this.dgvKeywordOccurrences);
            this.grpKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKeywords.Location = new System.Drawing.Point(3, 48);
            this.grpKeywords.Name = "grpKeywords";
            this.grpKeywords.Size = new System.Drawing.Size(794, 399);
            this.grpKeywords.TabIndex = 1;
            this.grpKeywords.TabStop = false;
            this.grpKeywords.Text = "Keywords";
            // 
            // dgvKeywordOccurrences
            // 
            this.dgvKeywordOccurrences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeywordOccurrences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKeywordOccurrences.Location = new System.Drawing.Point(3, 16);
            this.dgvKeywordOccurrences.Name = "dgvKeywordOccurrences";
            this.dgvKeywordOccurrences.Size = new System.Drawing.Size(788, 380);
            this.dgvKeywordOccurrences.ReadOnly = true;
            this.dgvKeywordOccurrences.TabIndex = 0;
            // 
            // DlgWebpageKeywordsFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Name = "DlgWebpageKeywordsFinder";
            this.Text = "Web page analyzer";
            this.tlpMain.ResumeLayout(false);
            this.tlpInputData.ResumeLayout(false);
            this.tlpWebPage.ResumeLayout(false);
            this.tlpWebPage.PerformLayout();
            this.grpKeywords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywordOccurrences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpInputData;
        private System.Windows.Forms.TableLayoutPanel tlpWebPage;
        private System.Windows.Forms.Label lblWebPageAddress;
        private System.Windows.Forms.TextBox txtWebPageAddress;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.GroupBox grpKeywords;
        private System.Windows.Forms.DataGridView dgvKeywordOccurrences;
    }
}

