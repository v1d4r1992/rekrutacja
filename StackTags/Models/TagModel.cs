using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using StackExchange.StacMan;

namespace StackTags.Models
{
	public class TagModel
	{
		public List<StackExchange.StacMan.Tag> TagCollection = new List<Tag>();
		public int AllUseCount;

		public TagModel()
		{
			GetTags();
		}

		private async Task GetTagsAsync()
		{
			StacManClient client = new StacManClient("9Cb1HN**U)0Eq1faZzkIAQ((", "2.0");

			for (int i = 1; i < 11; i++)
			{
				TagCollection.AddRange((await client.Tags.GetAll("stackoverflow", null, i, 100)).Data.Items);
			}

			AllUseCount = TagCollection.Sum(x => x.Count);
		}

		public void GetTagsFromArray(string[] tagArray)
		{
			TagCollection=TagCollection.Where(x => tagArray.Where(y => y == x.Name).Count() > 0).ToList();
		}

		public long GetSumOfCounts
		{
			get
			{
				return AllUseCount;
			}
		}

		private void GetTags()
		{
			Task.Run(async () => { await GetTagsAsync(); }).Wait();
		}
	}
}