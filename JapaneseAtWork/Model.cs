using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseAtWork
{
    public static class Model
    {
        /// <summary>
        /// 平假名 清音
        /// </summary>

        public static readonly List<ItemCollection> HiraganaClean =
        new List<ItemCollection>() { 
            new ItemCollection("あ","a","あ"), 
            new ItemCollection("い","i","あ"),
            new ItemCollection("う","u","あ"),
            new ItemCollection("え","e","あ"),
            new ItemCollection("お","o","あ"),
            new ItemCollection("か","ka","か"),
            new ItemCollection("き","ki","か"),
            new ItemCollection("く","ku","か"),
            new ItemCollection("け","ke","か"),
            new ItemCollection("こ","ko","か"),
            new ItemCollection("さ","sa","さ"),
            new ItemCollection("し","shi","さ"),
            new ItemCollection("す","su","さ"),
            new ItemCollection("せ","se","さ"),
            new ItemCollection("そ","so","さ"),
            new ItemCollection("た","ta","た"),
            new ItemCollection("ち","chi","た"),
            new ItemCollection("つ","tsu","た"),
            new ItemCollection("て","te","た"),
            new ItemCollection("と","to","た"),
            new ItemCollection("な","na","な"),
            new ItemCollection("に","ni","な"),
            new ItemCollection("ぬ","nu","な"),
            new ItemCollection("ね","ne","な"),
            new ItemCollection("の","no","な"),
            new ItemCollection("は","ha","は"),
            new ItemCollection("ひ","hi","は"),
            new ItemCollection("ふ","fu","は"),
            new ItemCollection("へ","he","は"),
            new ItemCollection("ほ","ho","は"),
            new ItemCollection("ま","ma","ま"),
            new ItemCollection("み","mi","ま"),
            new ItemCollection("む","mu","ま"),
            new ItemCollection("め","me","ま"),
            new ItemCollection("も","mo","ま"),
            new ItemCollection("や","ya","や"),
            new ItemCollection("ゆ","yu","や"),
            new ItemCollection("よ","yo","や"),
            new ItemCollection("ら","ra","ら"),
            new ItemCollection("り","ri","ら"),
            new ItemCollection("る","ru","ら"),
            new ItemCollection("れ","re","ら"),
            new ItemCollection("ろ","ro","ら"),
            new ItemCollection("わ","wa","わ"),
            new ItemCollection("を","wo","わ"),
            new ItemCollection("ん","n","ん")
        };

        /// <summary>
        /// 片假名 清音
        /// </summary>
        public static readonly List<ItemCollection> KatakanaClean =
            new List<ItemCollection>() { 
                       new ItemCollection("あ","a","あ"), 
            new ItemCollection("い","i","あ"),
            new ItemCollection("う","u","あ"),
            new ItemCollection("え","e","あ"),
            new ItemCollection("お","o","あ"),
            new ItemCollection("か","ka","か"),
            new ItemCollection("き","ki","か"),
            new ItemCollection("く","ku","か"),
            new ItemCollection("け","ke","か"),
            new ItemCollection("こ","ko","か"),
            new ItemCollection("さ","sa","さ"),
            new ItemCollection("し","shi","さ"),
            new ItemCollection("す","su","さ"),
            new ItemCollection("せ","se","さ"),
            new ItemCollection("そ","so","さ"),
            new ItemCollection("た","ta","た"),
            new ItemCollection("ち","chi","た"),
            new ItemCollection("つ","tsu","た"),
            new ItemCollection("て","te","た"),
            new ItemCollection("と","to","た"),
            new ItemCollection("な","na","な"),
            new ItemCollection("に","ni","な"),
            new ItemCollection("ぬ","nu","な"),
            new ItemCollection("ね","ne","な"),
            new ItemCollection("の","no","な"),
            new ItemCollection("は","ha","は"),
            new ItemCollection("ひ","hi","は"),
            new ItemCollection("ふ","fu","は"),
            new ItemCollection("へ","he","は"),
            new ItemCollection("ほ","ho","は"),
            new ItemCollection("ま","ma","ま"),
            new ItemCollection("み","mi","ま"),
            new ItemCollection("む","mu","ま"),
            new ItemCollection("め","me","ま"),
            new ItemCollection("も","mo","ま"),
            new ItemCollection("や","ya","や"),
            new ItemCollection("ゆ","yu","や"),
            new ItemCollection("よ","yo","や"),
            new ItemCollection("ら","ra","ら"),
            new ItemCollection("り","ri","ら"),
            new ItemCollection("る","ru","ら"),
            new ItemCollection("れ","re","ら"),
            new ItemCollection("ろ","ro","ら"),
            new ItemCollection("わ","wa","わ"),
            new ItemCollection("を","wo","わ"),
            new ItemCollection("ん","n","ん")
        }; 

        /// <summary>
        /// 平假名 濁音與半濁音
        /// </summary>
        public static readonly List<ItemCollection> HiraganaMuddy =
            new List<ItemCollection>() { 
            new ItemCollection("","",""), 
            new ItemCollection("","","")
        };

        /// <summary>
        /// 片假名 濁音與半濁音
        /// </summary>
        public static readonly List<ItemCollection> KatakanaMuddy =
            new List<ItemCollection>() { 
            new ItemCollection("","",""), 
            new ItemCollection("","","")
        };

        /// <summary>
        /// 平假名 拗音
        /// </summary>
        public static readonly List<ItemCollection> HiraganaBend =
            new List<ItemCollection>() { 
            new ItemCollection("","",""), 
            new ItemCollection("","","")
        };

        /// <summary>
        /// 片假名 拗音
        /// </summary>
        public static readonly List<ItemCollection> KatakanaBend =
            new List<ItemCollection>() { 
            new ItemCollection("","",""), 
            new ItemCollection("","","")
        };


        /// <summary>
        /// 打亂List的排序
        /// </summary>
        private static Random rng = new Random();  
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public class ItemCollection
    {
        //名稱
        public string Name { get; set; }
        //拼音
        public string Spell { get; set; }
        //位在哪一行
        public string Row { get; set; }

        public ItemCollection(string Name,string Spell,string Row) {
            this.Name = Name;
            this.Spell = Spell;
            this.Row = Row;
        }

    }
}
