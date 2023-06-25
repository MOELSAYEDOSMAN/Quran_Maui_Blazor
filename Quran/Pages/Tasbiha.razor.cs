using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quran.Pages
{
    public partial class Tasbiha
    {
        List<SbhaClass> TasbihaList { get; set; }
        protected override Task OnInitializedAsync()
        {
            TasbihaList = new List<SbhaClass>()
            {
                new SbhaClass{Id=1,Text="سُبْحَانَ اللَّهِ",rebist=100},
                new SbhaClass{Id=2,Text="سُبْحَانَ اللَّهِ وَبِحَمْدِهِ",rebist=100},
                new SbhaClass{Id=3,Text="سُبْحَانَ اللَّهِ وَالْحَمْدُ لِلَّهِ ",rebist=100},
                new SbhaClass{Id=4,Text="سُبْحَانَ اللهِ العَظِيمِ وَبِحَمْدِ",rebist=100},
                new SbhaClass{Id=5,Text="سُبْحَانَ اللَّهِ وَبِحَمْدِهِ ، سُبْحَانَ اللَّهِ الْعَظِيمِ",rebist=100},
                new SbhaClass{Id=6,Text="لَا إلَه إلّا اللهُ وَحْدَهُ لَا شَرِيكَ لَهُ، لَهُ الْمُلْكُ وَلَهُ الْحَمْدُ وَهُوَ عَلَى كُلُّ شَيْءِ قَدِيرِ",rebist=100},
                new SbhaClass{Id=7,Text="الْحَمْدُ للّهِ رَبِّ الْعَالَمِينَ",rebist=100},
                new SbhaClass{Id=8,Text="لا حَوْلَ وَلا قُوَّةَ إِلا بِاللَّهِ",rebist=100},
                new SbhaClass{Id=9,Text="الْلَّهُم صَلِّ وَسَلِم وَبَارِك عَلَى سَيِّدِنَا مُحَمَّد",rebist=100},
                new SbhaClass{Id=10,Text="أستغفر الله",rebist=100},
                new SbhaClass{Id=11,Text="سُبْحَانَ الْلَّهِ، وَالْحَمْدُ لِلَّهِ، وَلَا إِلَهَ إِلَّا الْلَّهُ، وَالْلَّهُ أَكْبَ",rebist=100},
                new SbhaClass{Id=12,Text="لَا إِلَهَ إِلَّا اللَّه",rebist=100},
                new SbhaClass{Id=13,Text="الْلَّهُ أَكْبَرُ",rebist=100},
                new SbhaClass{Id=14,Text="سُبْحَانَ اللَّهِ ، وَالْحَمْدُ لِلَّهِ ، وَلا إِلَهَ إِلا اللَّهُ ، وَاللَّهُ أَكْبَرُ ، اللَّهُمَّ اغْفِرْ لِي ، اللَّهُمَّ ارْحَمْنِي ، اللَّهُمَّ ارْزُقْنِي",rebist=100},
                new SbhaClass{Id=15,Text="الْحَمْدُ لِلَّهِ حَمْدًا كَثِيرًا طَيِّبًا مُبَارَكًا فِيهِ",rebist=100},
                new SbhaClass{Id=16,Text="اللَّهُ أَكْبَرُ كَبِيرًا ، وَالْحَمْدُ لِلَّهِ كَثِيرًا ، وَسُبْحَانَ اللَّهِ بُكْرَةً وَأَصِيلاً",rebist=100},
                new SbhaClass{Id=17,Text="اللَّهُمَّ صَلِّ عَلَى مُحَمَّدٍ وَعَلَى آلِ مُحَمَّدٍ كَمَا صَلَّيْتَ عَلَى إِبْرَاهِيمَ , وَعَلَى آلِ إِبْرَاهِيمَ إِنَّكَ حَمِيدٌ مَجِيدٌ , اللَّهُمَّ بَارِكْ عَلَى مُحَمَّدٍ وَعَلَى آلِ مُحَمَّدٍ كَمَا بَارَكْتَ عَلَى إِبْرَاهِيمَ وَعَلَى آلِ إِبْرَاهِيمَ إِنَّكَ حَمِيدٌ مَجِيدٌ",rebist=100},
            };
            return base.OnInitializedAsync();
        }
        public void ClickZaker(int id)
        {
            if (TasbihaList[id-1].rebist>0)
                TasbihaList[id-1].rebist--;
        }
    }
}
