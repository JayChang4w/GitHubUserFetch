using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GitHubUserFetch.Model
{
    public class GitHubUserRequest
    {
        private int? _since;

        /// <summary>
        /// A user ID. Only return users with an ID
        /// </summary>
        [JsonPropertyName("since")]
        public int? Since
        {
            get => this._since;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "value must be a positive integer");

                this._since = value;
            }
        }

        private int? _perPage;

        /// <summary>
        /// Results per page (max: 100, default: 30)
        /// </summary>
        [DefaultValue(null)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("per_page")]
        public int? PerPage 
        { 
            get => this._perPage;
            set
            {
                if (value != null && (value <= 0 || value >= 100))
                    throw new ArgumentOutOfRangeException(nameof(value), "value must be between 1 and 100");

                this._perPage = value;
            }
        }

        public IDictionary<string, string> GetQueryStringDict()
        {
            return new Dictionary<string, string>()
            {
                ["since"] = this.Since.ToString(),
                ["per_page"] = this.PerPage?.ToString(),
            };
        }
    }
}
