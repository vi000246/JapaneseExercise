using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseAtWork
{
    public static class Model
    {
        #region 平假名 清音
        /// <summary>
        /// 平假名 清音
        /// </summary>

        public static readonly List<ItemCollection> HiraganaClean =
        new List<ItemCollection>() { 
            new ItemCollection("あ","a","a"), 
            new ItemCollection("い","i","a"),
            new ItemCollection("う","u","a"),
            new ItemCollection("え","e","a"),
            new ItemCollection("お","o","a"),
            new ItemCollection("か","ka","k"),
            new ItemCollection("き","ki","k"),
            new ItemCollection("く","ku","k"),
            new ItemCollection("け","ke","k"),
            new ItemCollection("こ","ko","k"),
            new ItemCollection("さ","sa","s"),
            new ItemCollection("し","shi","s"),
            new ItemCollection("す","su","s"),
            new ItemCollection("せ","se","s"),
            new ItemCollection("そ","so","s"),
            new ItemCollection("た","ta","t"),
            new ItemCollection("ち","chi","t"),
            new ItemCollection("つ","tsu","t"),
            new ItemCollection("て","te","t"),
            new ItemCollection("と","to","t"),
            new ItemCollection("な","na","n"),
            new ItemCollection("に","ni","n"),
            new ItemCollection("ぬ","nu","n"),
            new ItemCollection("ね","ne","n"),
            new ItemCollection("の","no","n"),
            new ItemCollection("は","ha","h"),
            new ItemCollection("ひ","hi","h"),
            new ItemCollection("ふ","fu","h"),
            new ItemCollection("へ","he","h"),
            new ItemCollection("ほ","ho","h"),
            new ItemCollection("ま","ma","m"),
            new ItemCollection("み","mi","m"),
            new ItemCollection("む","mu","m"),
            new ItemCollection("め","me","m"),
            new ItemCollection("も","mo","m"),
            new ItemCollection("や","ya","y"),
            new ItemCollection("ゆ","yu","y"),
            new ItemCollection("よ","yo","y"),
            new ItemCollection("ら","ra","r"),
            new ItemCollection("り","ri","r"),
            new ItemCollection("る","ru","r"),
            new ItemCollection("れ","re","r"),
            new ItemCollection("ろ","ro","r"),
            new ItemCollection("わ","wa","w"),
            new ItemCollection("を","wo","w"),
            new ItemCollection("ん","n","n")
        };
        #endregion 
        #region 片假名 清音
        /// <summary>
        /// 片假名 清音
        /// </summary>
        public static readonly List<ItemCollection> KatakanaClean =
            new List<ItemCollection>() { 
            new ItemCollection("ア","a","a"), 
            new ItemCollection("イ","i","a"),
            new ItemCollection("ウ","u","a"),
            new ItemCollection("エ","e","a"),
            new ItemCollection("オ","o","a"),
            new ItemCollection("カ","ka","k"),
            new ItemCollection("キ","ki","k"),
            new ItemCollection("ク","ku","k"),
            new ItemCollection("ケ","ke","k"),
            new ItemCollection("コ","ko","k"),
            new ItemCollection("サ","sa","s"),
            new ItemCollection("シ","shi","s"),
            new ItemCollection("ス","su","s"),
            new ItemCollection("セ","se","s"),
            new ItemCollection("ソ","so","s"),
            new ItemCollection("タ","ta","t"),
            new ItemCollection("チ","chi","t"),
            new ItemCollection("ツ","tsu","t"),
            new ItemCollection("テ","te","t"),
            new ItemCollection("ト","to","t"),
            new ItemCollection("ナ","na","n"),
            new ItemCollection("ニ","ni","n"),
            new ItemCollection("ヌ","nu","n"),
            new ItemCollection("ネ","ne","n"),
            new ItemCollection("ノ","no","n"),
            new ItemCollection("ハ","ha","h"),
            new ItemCollection("ヒ","hi","h"),
            new ItemCollection("フ","fu","h"),
            new ItemCollection("ヘ","he","h"),
            new ItemCollection("ホ","ho","h"),
            new ItemCollection("マ","ma","m"),
            new ItemCollection("ミ","mi","m"),
            new ItemCollection("ム","mu","m"),
            new ItemCollection("メ","me","m"),
            new ItemCollection("モ","mo","m"),
            new ItemCollection("ヤ","ya","y"),
            new ItemCollection("ユ","yu","y"),
            new ItemCollection("ヨ","yo","y"),
            new ItemCollection("ラ","ra","r"),
            new ItemCollection("リ","ri","r"),
            new ItemCollection("ル","ru","r"),
            new ItemCollection("レ","re","r"),
            new ItemCollection("ロ","ro","r"),
            new ItemCollection("ワ","wa","w"),
            new ItemCollection("ヲ","wo","w"),
            new ItemCollection("ン","n","n")
        };
        #endregion
        #region 平假名 濁音與半濁音
        /// <summary>
        /// 平假名 濁音與半濁音
        /// </summary>
        public static readonly List<ItemCollection> HiraganaMuddy =
            new List<ItemCollection>() { 
            new ItemCollection("が","ga","g"), 
            new ItemCollection("ぎ","gi","g"),
            new ItemCollection("ぐ","gu","g"),
            new ItemCollection("げ","ge","g"),
            new ItemCollection("ご","go","g"),
            new ItemCollection("ざ","za","z"), 
            new ItemCollection("じ","ji","z"),
            new ItemCollection("ず","zu","z"),
            new ItemCollection("ぜ","ze","z"),
            new ItemCollection("ぞ","zo","z"),
            new ItemCollection("だ","da","d"), 
            new ItemCollection("ぢ","ji","d"),
            new ItemCollection("づ","du","d"),
            new ItemCollection("で","de","d"),
            new ItemCollection("ど","do","d"),
            new ItemCollection("ば","ba","b"), 
            new ItemCollection("び","bi","b"),
            new ItemCollection("ぶ","bu","b"),
            new ItemCollection("べ","be","b"),
            new ItemCollection("ぼ","bo","b"),
            new ItemCollection("ぱ","pa","p"), 
            new ItemCollection("ぴ","pi","p"),
            new ItemCollection("ぷ","pu","p"),
            new ItemCollection("ぺ","pe","p"),
            new ItemCollection("ぽ","po","p")
        };
        #endregion
        #region  片假名 濁音與半濁音
        /// <summary>
        /// 片假名 濁音與半濁音
        /// </summary>
        public static readonly List<ItemCollection> KatakanaMuddy =
            new List<ItemCollection>() { 
            new ItemCollection("ガ","ga","g"), 
            new ItemCollection("ギ","gi","g"),
            new ItemCollection("グ","gu","g"),
            new ItemCollection("ゲ","ge","g"),
            new ItemCollection("ゴ","go","g"),
            new ItemCollection("ザ","za","z"), 
            new ItemCollection("ジ","ji","z"),
            new ItemCollection("ズ","zu","z"),
            new ItemCollection("ゼ","ze","z"),
            new ItemCollection("ゾ","zo","z"),
            new ItemCollection("ダ","da","d"), 
            new ItemCollection("ヂ","ji","d"),
            new ItemCollection("ヅ","du","d"),
            new ItemCollection("デ","de","d"),
            new ItemCollection("ド","do","d"),
            new ItemCollection("バ","ba","b"), 
            new ItemCollection("ビ","bi","b"),
            new ItemCollection("ブ","bu","b"),
            new ItemCollection("ベ","be","b"),
            new ItemCollection("ボ","bo","b"),
            new ItemCollection("パ","pa","p"), 
            new ItemCollection("ピ","pi","p"),
            new ItemCollection("プ","pu","p"),
            new ItemCollection("ペ","pe","p"),
            new ItemCollection("ポ","po","p")
        };
        #endregion
        #region 平假名 拗音
        /// <summary>
        /// 平假名 拗音
        /// </summary>
        public static readonly List<ItemCollection> HiraganaBend =
            new List<ItemCollection>() { 
            new ItemCollection("きゃ","kya","k"), 
            new ItemCollection("きゅ","kyu","k"),
            new ItemCollection("きょ","kyo","k"), 
            new ItemCollection("しゃ","sha","s"),
            new ItemCollection("しゅ","shu","s"), 
            new ItemCollection("しょ","sho","s"),
            new ItemCollection("ちゃ","cha","c"), 
            new ItemCollection("ちゅ","chu","c"),
            new ItemCollection("ちょ","cho","c"), 
            new ItemCollection("にゃ","nya","n"),
            new ItemCollection("にゅ","nyu","n"), 
            new ItemCollection("にょ","nyo","n"), 
            new ItemCollection("ひゃ","hya","h"),
            new ItemCollection("ひゅ","hyu","h"), 
            new ItemCollection("ひょ","hyo","h"),
            new ItemCollection("みゃ","mya","m"), 
            new ItemCollection("みゅ","myu","m"),
            new ItemCollection("みょ","myo","m"), 
            new ItemCollection("りゃ","rya","r"),
            new ItemCollection("りゅ","ryu","r"), 
            new ItemCollection("りょ","ryo","r"),
            new ItemCollection("ぎゃ","gya","g"), 
            new ItemCollection("ぎゅ","gyu","g"), 
            new ItemCollection("ぎょ","gyo","g"),
            new ItemCollection("じゃ","ja","j"), 
            new ItemCollection("じゅ","ju","j"),
            new ItemCollection("じょ","jo","j"), 
            new ItemCollection("びゃ","bya","b"),
            new ItemCollection("びゅ","byu","b"), 
            new ItemCollection("びょ","byo","b"),
            new ItemCollection("ぴゃ","pya","p"), 
            new ItemCollection("ぴゅ","pyu","p"),
            new ItemCollection("ぴょ","pyo","p")
        };
        #endregion
        #region 片假名 拗音
        /// <summary>
        /// 片假名 拗音
        /// </summary>
        public static readonly List<ItemCollection> KatakanaBend =
            new List<ItemCollection>() { 
            new ItemCollection("キャ","kya","k"), 
            new ItemCollection("キュ","kyu","k"),
            new ItemCollection("キョ","kyo","k"), 
            new ItemCollection("シャ","sha","s"),
            new ItemCollection("シュ","shu","s"), 
            new ItemCollection("ショ","sho","s"),
            new ItemCollection("チャ","cha","c"), 
            new ItemCollection("チュ","chu","c"),
            new ItemCollection("チョ","cho","c"), 
            new ItemCollection("ニャ","nya","n"),
            new ItemCollection("ニュ","nyu","n"), 
            new ItemCollection("ニョ","nyo","n"), 
            new ItemCollection("ヒャ","hya","h"),
            new ItemCollection("ヒュ","hyu","h"), 
            new ItemCollection("ヒョ","hyo","h"),
            new ItemCollection("ミャ","mya","m"), 
            new ItemCollection("ミュ","myu","m"),
            new ItemCollection("ミョ","myo","m"), 
            new ItemCollection("リャ","rya","r"),
            new ItemCollection("リュ","ryu","r"), 
            new ItemCollection("リョ","ryo","r"),
            new ItemCollection("ギャ","gya","g"), 
            new ItemCollection("ギュ","gyu","g"), 
            new ItemCollection("ギョ","gyo","g"),
            new ItemCollection("ジャ","ja","j"), 
            new ItemCollection("ジュ","ju","j"),
            new ItemCollection("ジョ","jo","j"), 
            new ItemCollection("ビャ","bya","b"),
            new ItemCollection("ビュ","byu","b"), 
            new ItemCollection("ビョ","byo","b"),
            new ItemCollection("ピャ","pya","p"), 
            new ItemCollection("ピュ","pyu","p"),
            new ItemCollection("ピョ","pyo","p")
        };
        #endregion 

        /// <summary>
        /// 測試用
        /// </summary>
        public static readonly List<ItemCollection> Test =
            new List<ItemCollection>() { 
            new ItemCollection("a","a","1"), 
            new ItemCollection("b","b","1"),
            new ItemCollection("c","c","2"),
            new ItemCollection("d","d","2"),
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
