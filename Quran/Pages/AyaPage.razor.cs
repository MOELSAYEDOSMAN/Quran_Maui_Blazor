using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quran.Pages
{
    public partial class AyaPage
    {
        [Parameter]
        public int Id { get; set; }
        public Ayat ayat { get; set; }
        public List<Ayat> Ayats { get; set; }
        public bool lodding = false;
        protected override async Task OnInitializedAsync()
        {
            using var strem = await FileSystem.OpenAppPackageFileAsync(@"wwwroot\Data\Quran.json");
            using var reader = new StreamReader(strem);
            string json = await reader.ReadToEndAsync();
            Ayats = JsonSerializer.Deserialize<List<Ayat>>(json);
            ayat = Ayats.SingleOrDefault(x => x.id == Id);
            lodding = true;
        }

        public void NextAya()
        {
            Id++;
            ayat = Ayats.SingleOrDefault(x => x.id == Id);
        }

        public void PervAya()
        {
            Id--;
            ayat = Ayats.SingleOrDefault(x => x.id == Id);
        }
    }
}
