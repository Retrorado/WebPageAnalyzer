using Adapters;
using DTO;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TextResources;

namespace Dialogs
{
    public partial class DlgWebpageKeywordsFinder : Form
    {
        #region Parameters

        private string WebPageAddress => txtWebPageAddress.Text;

        private List<KeywordDto> _webPageKeywordsOccurrences;

        private IWebPageAdapter _webPageAdapter;

        #endregion

        #region Constructors

        public DlgWebpageKeywordsFinder()
        {
            Init();
            InitializeComponent();
        }

        #endregion

        #region UI event handlers

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            Analyze();
        }

        #endregion

        #region Private methods

        private void Init()
        {
            _webPageAdapter = new WebPageAdapter();
        }

        /// <summary>
        /// Analyze webpage content.
        /// Fills grid view.
        /// </summary>
        private void Analyze()
        {
            SetControls(true);

            if (_webPageAdapter.IsUrlValid(WebPageAddress))
            {
                var keywords = GetKeywordsFromWebpage();
                GetOccurrencesOfKeywordsInWebpage(keywords);
                FillKeywordsGridView();
            }
            else
            {
                MessageBox.Show(TextResources.WebpageKeywordsFinderResources.MsgInvalidUrl);
            }

            SetControls(false);
        }

        private IEnumerable<string> GetKeywordsFromWebpage()
        {
            var keywords = new List<string>();
            if (!string.IsNullOrEmpty(WebPageAddress))
            {
                keywords = _webPageAdapter.GetKeywords(WebPageAddress);
            }
            else
            {
                MessageBox.Show(WebpageKeywordsFinderResources.MsgEmptyUrl);
            }

            return keywords;
        }

        private void GetOccurrencesOfKeywordsInWebpage(IEnumerable<string> keywords)
        {
            _webPageKeywordsOccurrences = _webPageAdapter.GetKeywordsOccurrences(keywords, WebPageAddress);
        }

        private void FillKeywordsGridView()
        {
            dgvKeywordOccurrences.DataSource = _webPageKeywordsOccurrences;
        }

        private void SetControls(bool isBusy)
        {
            btnAnalyze.Enabled = !isBusy;
            lblWebPageAddress.Enabled = !isBusy;
            Cursor.Current = isBusy ? Cursors.WaitCursor : Cursors.Default;
        }

        #endregion

    }
}
