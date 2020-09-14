
namespace Gako.Data.EntityBinder
{
    
    /// <summary>
    /// 文字エンコーディングのコードページ ID を表します。
    /// </summary>
    public enum CodePage
    {
        
            /// <summary>
            /// IBM EBCDIC (US - カナダ)
            /// </summary>
            CP37_IBM037 = 37,
        
            /// <summary>
            /// OEM アメリカ合衆国
            /// </summary>
            CP437_IBM437 = 437,
        
            /// <summary>
            /// IBM EBCDIC (インターナショナル)
            /// </summary>
            CP500_IBM500 = 500,
        
            /// <summary>
            /// アラビア語 (ASMO 708)
            /// </summary>
            CP708_ASMO_708 = 708,
        
            /// <summary>
            /// アラビア語 (DOS)
            /// </summary>
            CP720_DOS_720 = 720,
        
            /// <summary>
            /// ギリシャ語 (DOS)
            /// </summary>
            CP737_ibm737 = 737,
        
            /// <summary>
            /// バルト言語 (DOS)
            /// </summary>
            CP775_ibm775 = 775,
        
            /// <summary>
            /// 西ヨーロッパ言語 (DOS)
            /// </summary>
            CP850_ibm850 = 850,
        
            /// <summary>
            /// 中央ヨーロッパ言語 (DOS)
            /// </summary>
            CP852_ibm852 = 852,
        
            /// <summary>
            /// OEM キリル
            /// </summary>
            CP855_IBM855 = 855,
        
            /// <summary>
            /// トルコ語 (DOS)
            /// </summary>
            CP857_ibm857 = 857,
        
            /// <summary>
            /// OEM マルチリンガル ラテン I
            /// </summary>
            CP858_IBM00858 = 858,
        
            /// <summary>
            /// ポルトガル語  (DOS)
            /// </summary>
            CP860_IBM860 = 860,
        
            /// <summary>
            /// アイスランド語 (DOS)
            /// </summary>
            CP861_ibm861 = 861,
        
            /// <summary>
            /// ヘブライ語 (DOS)
            /// </summary>
            CP862_DOS_862 = 862,
        
            /// <summary>
            /// フランス語 (カナダ) (DOS)
            /// </summary>
            CP863_IBM863 = 863,
        
            /// <summary>
            /// アラビア語 (864)
            /// </summary>
            CP864_IBM864 = 864,
        
            /// <summary>
            /// 北欧 (DOS)
            /// </summary>
            CP865_IBM865 = 865,
        
            /// <summary>
            /// キリル言語 (DOS)
            /// </summary>
            CP866_cp866 = 866,
        
            /// <summary>
            /// ギリシャ語, Modern (DOS)
            /// </summary>
            CP869_ibm869 = 869,
        
            /// <summary>
            /// IBM EBCDIC (多国語ラテン 2)
            /// </summary>
            CP870_IBM870 = 870,
        
            /// <summary>
            /// タイ語 (Windows)
            /// </summary>
            CP874_windows_874 = 874,
        
            /// <summary>
            /// IBM EBCDIC (ギリシャ語 Modern)
            /// </summary>
            CP875_cp875 = 875,
        
            /// <summary>
            /// 日本語 (シフト JIS)
            /// </summary>
            CP932_shift_jis = 932,
        
            /// <summary>
            /// 簡体字中国語 (GB2312)
            /// </summary>
            CP936_gb2312 = 936,
        
            /// <summary>
            /// 韓国語
            /// </summary>
            CP949_ks_c_5601_1987 = 949,
        
            /// <summary>
            /// 繁体字中国語 (Big5)
            /// </summary>
            CP950_big5 = 950,
        
            /// <summary>
            /// IBM EBCDIC (トルコ語ラテン 5)
            /// </summary>
            CP1026_IBM1026 = 1026,
        
            /// <summary>
            /// IBM ラテン-1
            /// </summary>
            CP1047_IBM01047 = 1047,
        
            /// <summary>
            /// IBM EBCDIC (US - カナダ - ヨーロッパ)
            /// </summary>
            CP1140_IBM01140 = 1140,
        
            /// <summary>
            /// IBM EBCDIC (ドイツ - ヨーロッパ)
            /// </summary>
            CP1141_IBM01141 = 1141,
        
            /// <summary>
            /// IBM EBCDIC (デンマーク - ノルウェー - ヨーロッパ)
            /// </summary>
            CP1142_IBM01142 = 1142,
        
            /// <summary>
            /// IBM EBCDIC (フィンランド - スウェーデン - ヨーロッパ)
            /// </summary>
            CP1143_IBM01143 = 1143,
        
            /// <summary>
            /// IBM EBCDIC (イタリア - ヨーロッパ)
            /// </summary>
            CP1144_IBM01144 = 1144,
        
            /// <summary>
            /// IBM EBCDIC (スペイン - ヨーロッパ)
            /// </summary>
            CP1145_IBM01145 = 1145,
        
            /// <summary>
            /// IBM EBCDIC (UK - ヨーロッパ)
            /// </summary>
            CP1146_IBM01146 = 1146,
        
            /// <summary>
            /// IBM EBCDIC (フランス - ヨーロッパ)
            /// </summary>
            CP1147_IBM01147 = 1147,
        
            /// <summary>
            /// IBM EBCDIC (インターナショナル - ヨーロッパ)
            /// </summary>
            CP1148_IBM01148 = 1148,
        
            /// <summary>
            /// IBM EBCDIC (アイスランド語 - ヨーロッパ)
            /// </summary>
            CP1149_IBM01149 = 1149,
        
            /// <summary>
            /// Unicode
            /// </summary>
            CP1200_utf_16 = 1200,
        
            /// <summary>
            /// Unicode (Big-Endian)
            /// </summary>
            CP1201_utf_16BE = 1201,
        
            /// <summary>
            /// 中央ヨーロッパ言語 (Windows)
            /// </summary>
            CP1250_windows_1250 = 1250,
        
            /// <summary>
            /// キリル言語 (Windows)
            /// </summary>
            CP1251_windows_1251 = 1251,
        
            /// <summary>
            /// 西ヨーロッパ言語 (Windows)
            /// </summary>
            CP1252_Windows_1252 = 1252,
        
            /// <summary>
            /// ギリシャ語 (Windows)
            /// </summary>
            CP1253_windows_1253 = 1253,
        
            /// <summary>
            /// トルコ語 (Windows)
            /// </summary>
            CP1254_windows_1254 = 1254,
        
            /// <summary>
            /// ヘブライ語 (Windows)
            /// </summary>
            CP1255_windows_1255 = 1255,
        
            /// <summary>
            /// アラビア語 (Windows)
            /// </summary>
            CP1256_windows_1256 = 1256,
        
            /// <summary>
            /// バルト言語 (Windows)
            /// </summary>
            CP1257_windows_1257 = 1257,
        
            /// <summary>
            /// ベトナム語 (Windows)
            /// </summary>
            CP1258_windows_1258 = 1258,
        
            /// <summary>
            /// 韓国語 (Johab)
            /// </summary>
            CP1361_Johab = 1361,
        
            /// <summary>
            /// 西ヨーロッパ言語 (Mac)
            /// </summary>
            CP10000_macintosh = 10000,
        
            /// <summary>
            /// 日本語 (Mac)
            /// </summary>
            CP10001_x_mac_japanese = 10001,
        
            /// <summary>
            /// 繁体字中国語 (Mac)
            /// </summary>
            CP10002_x_mac_chinesetrad = 10002,
        
            /// <summary>
            /// 韓国語 (Mac)
            /// </summary>
            CP10003_x_mac_korean = 10003,
        
            /// <summary>
            /// アラビア語 (Mac)
            /// </summary>
            CP10004_x_mac_arabic = 10004,
        
            /// <summary>
            /// ヘブライ語 (Mac)
            /// </summary>
            CP10005_x_mac_hebrew = 10005,
        
            /// <summary>
            /// ギリシャ語 (Mac)
            /// </summary>
            CP10006_x_mac_greek = 10006,
        
            /// <summary>
            /// キリル言語 (Mac)
            /// </summary>
            CP10007_x_mac_cyrillic = 10007,
        
            /// <summary>
            /// 簡体字中国語 (Mac)
            /// </summary>
            CP10008_x_mac_chinesesimp = 10008,
        
            /// <summary>
            /// ルーマニア語 (Mac)
            /// </summary>
            CP10010_x_mac_romanian = 10010,
        
            /// <summary>
            /// ウクライナ語 (Mac)
            /// </summary>
            CP10017_x_mac_ukrainian = 10017,
        
            /// <summary>
            /// タイ語 (Mac)
            /// </summary>
            CP10021_x_mac_thai = 10021,
        
            /// <summary>
            /// 中央ヨーロッパ言語 (Mac)
            /// </summary>
            CP10029_x_mac_ce = 10029,
        
            /// <summary>
            /// アイスランド語 (Mac)
            /// </summary>
            CP10079_x_mac_icelandic = 10079,
        
            /// <summary>
            /// トルコ語 (Mac)
            /// </summary>
            CP10081_x_mac_turkish = 10081,
        
            /// <summary>
            /// クロアチア語 (Mac)
            /// </summary>
            CP10082_x_mac_croatian = 10082,
        
            /// <summary>
            /// Unicode (UTF-32)
            /// </summary>
            CP12000_utf_32 = 12000,
        
            /// <summary>
            /// Unicode (UTF-32 ビッグ エンディアン)
            /// </summary>
            CP12001_utf_32BE = 12001,
        
            /// <summary>
            /// 繁体字中国語 (CNS)
            /// </summary>
            CP20000_x_Chinese_CNS = 20000,
        
            /// <summary>
            /// TCA 台湾
            /// </summary>
            CP20001_x_cp20001 = 20001,
        
            /// <summary>
            /// 繁体字中国語 (Eten)
            /// </summary>
            CP20002_x_Chinese_Eten = 20002,
        
            /// <summary>
            /// IBM5550 台湾
            /// </summary>
            CP20003_x_cp20003 = 20003,
        
            /// <summary>
            /// TeleText 台湾
            /// </summary>
            CP20004_x_cp20004 = 20004,
        
            /// <summary>
            /// Wang 台湾
            /// </summary>
            CP20005_x_cp20005 = 20005,
        
            /// <summary>
            /// 西ヨーロッパ言語 (IA5)
            /// </summary>
            CP20105_x_IA5 = 20105,
        
            /// <summary>
            /// ドイツ語 (IA5)
            /// </summary>
            CP20106_x_IA5_German = 20106,
        
            /// <summary>
            /// スウェーデン語 (IA5)
            /// </summary>
            CP20107_x_IA5_Swedish = 20107,
        
            /// <summary>
            /// ノルウェー語 (IA5)
            /// </summary>
            CP20108_x_IA5_Norwegian = 20108,
        
            /// <summary>
            /// US-ASCII
            /// </summary>
            CP20127_us_ascii = 20127,
        
            /// <summary>
            /// T.61
            /// </summary>
            CP20261_x_cp20261 = 20261,
        
            /// <summary>
            /// ISO-6937
            /// </summary>
            CP20269_x_cp20269 = 20269,
        
            /// <summary>
            /// IBM EBCDIC (ドイツ)
            /// </summary>
            CP20273_IBM273 = 20273,
        
            /// <summary>
            /// IBM EBCDIC (デンマーク - ノルウェー)
            /// </summary>
            CP20277_IBM277 = 20277,
        
            /// <summary>
            /// IBM EBCDIC (フィンランド - スウェーデン)
            /// </summary>
            CP20278_IBM278 = 20278,
        
            /// <summary>
            /// IBM EBCDIC (イタリア)
            /// </summary>
            CP20280_IBM280 = 20280,
        
            /// <summary>
            /// IBM EBCDIC (スペイン)
            /// </summary>
            CP20284_IBM284 = 20284,
        
            /// <summary>
            /// IBM EBCDIC (UK)
            /// </summary>
            CP20285_IBM285 = 20285,
        
            /// <summary>
            /// IBM EBCDIC (日本語カタカナ)
            /// </summary>
            CP20290_IBM290 = 20290,
        
            /// <summary>
            /// IBM EBCDIC (フランス)
            /// </summary>
            CP20297_IBM297 = 20297,
        
            /// <summary>
            /// IBM EBCDIC (アラビア語)
            /// </summary>
            CP20420_IBM420 = 20420,
        
            /// <summary>
            /// IBM EBCDIC (ギリシャ語)
            /// </summary>
            CP20423_IBM423 = 20423,
        
            /// <summary>
            /// IBM EBCDIC (ヘブライ語)
            /// </summary>
            CP20424_IBM424 = 20424,
        
            /// <summary>
            /// IBM EBCDIC (韓国語 Extended)
            /// </summary>
            CP20833_x_EBCDIC_KoreanExtended = 20833,
        
            /// <summary>
            /// IBM EBCDIC (タイ語)
            /// </summary>
            CP20838_IBM_Thai = 20838,
        
            /// <summary>
            /// キリル言語 (KOI8-R)
            /// </summary>
            CP20866_koi8_r = 20866,
        
            /// <summary>
            /// IBM EBCDIC (アイスランド語)
            /// </summary>
            CP20871_IBM871 = 20871,
        
            /// <summary>
            /// IBM EBCDIC (キリル言語 - ロシア語)
            /// </summary>
            CP20880_IBM880 = 20880,
        
            /// <summary>
            /// IBM EBCDIC (トルコ語)
            /// </summary>
            CP20905_IBM905 = 20905,
        
            /// <summary>
            /// IBM ラテン-1
            /// </summary>
            CP20924_IBM00924 = 20924,
        
            /// <summary>
            /// 日本語 (JIS 0208-1990 および 0212-1990)
            /// </summary>
            CP20932_EUC_JP = 20932,
        
            /// <summary>
            /// 簡体字中国語 (GB2312-80)
            /// </summary>
            CP20936_x_cp20936 = 20936,
        
            /// <summary>
            /// 韓国語 Wansung
            /// </summary>
            CP20949_x_cp20949 = 20949,
        
            /// <summary>
            /// IBM EBCDIC (キリル言語 セルビア - ブルガリア)
            /// </summary>
            CP21025_cp1025 = 21025,
        
            /// <summary>
            /// キリル言語 (KOI8-U)
            /// </summary>
            CP21866_koi8_u = 21866,
        
            /// <summary>
            /// 西ヨーロッパ言語 (ISO)
            /// </summary>
            CP28591_iso_8859_1 = 28591,
        
            /// <summary>
            /// 中央ヨーロッパ言語 (ISO)
            /// </summary>
            CP28592_iso_8859_2 = 28592,
        
            /// <summary>
            /// ラテン 3 (ISO)
            /// </summary>
            CP28593_iso_8859_3 = 28593,
        
            /// <summary>
            /// バルト言語 (ISO)
            /// </summary>
            CP28594_iso_8859_4 = 28594,
        
            /// <summary>
            /// キリル言語 (ISO)
            /// </summary>
            CP28595_iso_8859_5 = 28595,
        
            /// <summary>
            /// アラビア語 (ISO)
            /// </summary>
            CP28596_iso_8859_6 = 28596,
        
            /// <summary>
            /// ギリシャ語 (ISO)
            /// </summary>
            CP28597_iso_8859_7 = 28597,
        
            /// <summary>
            /// ヘブライ語 (ISO-Visual)
            /// </summary>
            CP28598_iso_8859_8 = 28598,
        
            /// <summary>
            /// トルコ語 (ISO)
            /// </summary>
            CP28599_iso_8859_9 = 28599,
        
            /// <summary>
            /// エストニア語 (ISO)
            /// </summary>
            CP28603_iso_8859_13 = 28603,
        
            /// <summary>
            /// ラテン 9 (ISO)
            /// </summary>
            CP28605_iso_8859_15 = 28605,
        
            /// <summary>
            /// ヨーロッパ
            /// </summary>
            CP29001_x_Europa = 29001,
        
            /// <summary>
            /// ヘブライ語 (ISO-Logical)
            /// </summary>
            CP38598_iso_8859_8_i = 38598,
        
            /// <summary>
            /// 日本語 (JIS)
            /// </summary>
            CP50220_iso_2022_jp = 50220,
        
            /// <summary>
            /// 日本語 (JIS 1 バイト カタカナ可)
            /// </summary>
            CP50221_csISO2022JP = 50221,
        
            /// <summary>
            /// 日本語 (JIS 1 バイト カタカナ可 - SO/SI)
            /// </summary>
            CP50222_iso_2022_jp = 50222,
        
            /// <summary>
            /// 韓国語 (ISO)
            /// </summary>
            CP50225_iso_2022_kr = 50225,
        
            /// <summary>
            /// 簡体字中国語 (ISO-2022)
            /// </summary>
            CP50227_x_cp50227 = 50227,
        
            /// <summary>
            /// 日本語 (EUC)
            /// </summary>
            CP51932_euc_jp = 51932,
        
            /// <summary>
            /// 簡体字中国語 (EUC)
            /// </summary>
            CP51936_EUC_CN = 51936,
        
            /// <summary>
            /// 韓国語 (EUC)
            /// </summary>
            CP51949_euc_kr = 51949,
        
            /// <summary>
            /// 簡体字中国語 (HZ)
            /// </summary>
            CP52936_hz_gb_2312 = 52936,
        
            /// <summary>
            /// 簡体字中国語 (GB18030)
            /// </summary>
            CP54936_GB18030 = 54936,
        
            /// <summary>
            /// ISCII デバナガリ文字
            /// </summary>
            CP57002_x_iscii_de = 57002,
        
            /// <summary>
            /// ISCII ベンガル語
            /// </summary>
            CP57003_x_iscii_be = 57003,
        
            /// <summary>
            /// ISCII タミール語
            /// </summary>
            CP57004_x_iscii_ta = 57004,
        
            /// <summary>
            /// ISCII テルグ語
            /// </summary>
            CP57005_x_iscii_te = 57005,
        
            /// <summary>
            /// ISCII アッサム語
            /// </summary>
            CP57006_x_iscii_as = 57006,
        
            /// <summary>
            /// ISCII オリヤー語
            /// </summary>
            CP57007_x_iscii_or = 57007,
        
            /// <summary>
            /// ISCII カナラ語
            /// </summary>
            CP57008_x_iscii_ka = 57008,
        
            /// <summary>
            /// ISCII マラヤラム語
            /// </summary>
            CP57009_x_iscii_ma = 57009,
        
            /// <summary>
            /// ISCII グジャラート語
            /// </summary>
            CP57010_x_iscii_gu = 57010,
        
            /// <summary>
            /// ISCII パンジャブ語
            /// </summary>
            CP57011_x_iscii_pa = 57011,
        
            /// <summary>
            /// Unicode (UTF-7)
            /// </summary>
            CP65000_utf_7 = 65000,
        
            /// <summary>
            /// Unicode (UTF-8)
            /// </summary>
            CP65001_utf_8 = 65001,
            }
}
