using Quran.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quran.Pages
{
    public partial class Azkar
    {
        public AzkarRoot azkar { get; set; }
        
        public bool Lodding = false;

        protected override async Task OnInitializedAsync()
        {
            var time = DateTime.Now.TimeOfDay;
            //Time Azkar Sbah
            var startTime = new TimeSpan(4, 0, 0);
            var endTime = new TimeSpan(16, 0, 0);
            if(time>=startTime&&time<=endTime)
            {
                using var strem = await FileSystem.OpenAppPackageFileAsync(@"wwwroot\Data\azkar_sabah.json");
                using var reader = new StreamReader(strem);
                string json = await reader.ReadToEndAsync();
                azkar = JsonSerializer.Deserialize<AzkarRoot>(json);
            }
            else
            {
                using var strem = await FileSystem.OpenAppPackageFileAsync(@"wwwroot\Data\azkar_massa.json");
                using var reader = new StreamReader(strem);
                string json = await reader.ReadToEndAsync();
                azkar = JsonSerializer.Deserialize<AzkarRoot>(json);

            }
            Lodding = true;
        }
        
    }
}
