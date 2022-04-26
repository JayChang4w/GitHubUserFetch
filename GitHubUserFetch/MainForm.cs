using GitHubUserFetch.Model;
using GitHubUserFetch.Service;

using ReaLTaiizor;
using ReaLTaiizor.Forms;

using System.Data;

namespace GitHubUserFetch
{
    public partial class MainForm : MetroForm
    {
        private readonly IGitHubAPIService _gitHubUserService;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly DataTable _dataTable;
        private readonly GitHubUserRequest _request;

        private int _pageNumber = 1;

        public MainForm(IGitHubAPIService gitHubUserService, IHttpClientFactory httpClientFactory)
        {
            this._gitHubUserService = gitHubUserService;
            this._httpClientFactory = httpClientFactory;
            this._dataTable = new DataTable();
            this._request = new GitHubUserRequest();


            InitializeComponent();
            InitControls();

        }

        private void InitControls()
        {
            txtPageNumber.Text = this._pageNumber.ToString();

            this._dataTable.Columns.Add("no", typeof(int));
            this._dataTable.Columns.Add(nameof(GitHubUserResponse.id), typeof(int));
            this._dataTable.Columns.Add(nameof(GitHubUserResponse.login), typeof(string));
            this._dataTable.Columns.Add(nameof(GitHubUserResponse.site_admin), typeof(bool));
            //this._dataTable.Columns.Add(nameof(GitHubUserResponse.avatar_url), typeof(string));
            this._dataTable.Columns.Add("avatar", typeof(byte[]));

            DataGridView dataGridView = new DataGridView();

            this.Controls.Add(dataGridView);

            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            dataGridView.DataSource = this._dataTable;
            dataGridView.RowTemplate.Height = 300;
            dataGridView.AllowUserToAddRows = false;
        }

        private async void btnQuery_Click(object sender, EventArgs e)
        {
            await InvokeAsync();
        }

        private async Task InvokeAsync()
        {
            this._request.PerPage = numPerSize.Value;
            this._request.Since = _pageNumber == 1 ? null : (_pageNumber - 1) * numPerSize.Value;

            this._dataTable.Clear();

            using (var httpClient = this._httpClientFactory.CreateClient())
            {
                var users = await _gitHubUserService.GetUsersAsync(_request);

                int no = 0;
                foreach (var item in users)
                {
                    DataRow row = this._dataTable.NewRow();
                    row["no"] = ++no;
                    row[nameof(GitHubUserResponse.id)] = item.id;
                    row[nameof(GitHubUserResponse.login)] = item.login;
                    row[nameof(GitHubUserResponse.site_admin)] = item.site_admin;
                    //row[nameof(GitHubUserResponse.avatar_url)] = item.avatar_url;
                    row["avatar"] = await httpClient.GetByteArrayAsync(item.avatar_url);
                    this._dataTable.Rows.Add(row);
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this._pageNumber = this._pageNumber > 1 ? this._pageNumber - 1 : 1;
            txtPageNumber.Text = this._pageNumber.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this._pageNumber++;
            txtPageNumber.Text = this._pageNumber.ToString();
        }
    }
}