using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quran.Pages
{
	public partial class AyatList
	{
        public List<Ayat> Ayats { get; set; }
        public List<Ayat> Ayats1 { get; set; }

        public bool LoddingPage = false;
        public string SearchString { get; set; } = "";
        public void SerchMethod()
        {
            if (SearchString.Length > 0)
                Ayats = Ayats1.Where(x => x.name.Contains(SearchString)).ToList();
            else
                Ayats = Ayats1;
        }
        protected override async Task OnInitializedAsync()
        {


            using var strem = await FileSystem.OpenAppPackageFileAsync(@"wwwroot\Data\Quran.json");
            using var reader=new StreamReader(strem);
            string json =await reader.ReadToEndAsync();
            Ayats = JsonSerializer.Deserialize<List<Ayat>>(json);
            Ayats1 = new List<Ayat>();
                Ayats1 = Ayats.ToList();
                LoddingPage = true;
            


        }
    }
}
