using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_tweak_tool.src.policies.lang
{
    class Languages
    {

        public static Languages langs;

        private Dictionary<Phrase, Dictionary<Language, string>> language = new Dictionary<Phrase, Dictionary<Language, string>>();

        protected Languages() {

        }

        public Language getCurrentLanguage()
        {
            //TODO: gets the current system language
            throw new NotImplementedException("getCurrentLanguage() is not implemented yet.");
        }

        public void importLanguage(Phrase[] phrases)
        {
            //TODO: let the policy insert ít's own language bundles and langtags if they don't exist.
            foreach(Phrase phrase in phrases)
            {
                if(!language.ContainsKey(phrase))
                {
                    //language.Add(phrase);
                }
            }
        }

        public void isLanguageAvailiable(Policy p)
        {
            //TODO: uses the getCurrentLanguage to determine if it matches any language bundle inside the Dictionary, if not the policy will be disabled, this function may gets builded into the Policy class.
        }


        public string getPhrase(Phrase phrase)
        {
            if(language.ContainsKey(phrase))
            {
                if(language[phrase].ContainsKey(getCurrentLanguage()))
                {
                    return language[phrase][getCurrentLanguage()];
                }
            }
            throw new Exception("language is not supported !");
        }

        public static Languages getLanguageFactory()
        {
            if(langs == null)
            {
                langs = new Languages();
            }
            return langs;
        }

       public class Language
        {
            //https://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx

            private HashSet<Language> set = new HashSet<Language>();

            public static Language SOUTH_AFRICA = new Language("af-ZA", "South Africa");
            public static Language ALBANIA = new Language("sq-AL", "Albania");
            public static Language ALGERIA = new Language("ar-DZ", "Algeria");
            public static Language BAHRAIN = new Language("ar-BH", "Bahrain");
            public static Language EGYPT = new Language("ar-EG", "Egypt");
            public static Language IRAQ = new Language("ar-IQ", "Iraq");
            public static Language JORDAN = new Language("ar-JO", "Jordan");
            public static Language KUWAIT = new Language("ar-KW", "Kuwait");
            public static Language LEBANON = new Language("ar-LB", "Lebanon");
            public static Language LIBYA = new Language("ar-LY", "Libya");
            public static Language MAROCCO = new Language("ar-MA", "Morocco");
            public static Language OMAN = new Language("ar-OM", "Oman");
            public static Language QATAR = new Language("ar-QA", "Qatar");
            public static Language SAUDI_ARABIA = new Language("ar-SA", "South Africa");
            public static Language SYRIA = new Language("ar-SY", "Syria");
            public static Language TUNISIA = new Language("ar-TN", "Tunisia");
            public static Language UNITED_ARAB_EMIRATES = new Language("ar-AE", "United Arab Emirates");
            public static Language YEMEN = new Language("ar-YE", "Yemen");
            public static Language ARMENIA = new Language("hy-AM", "Armenia");
            public static Language AZERBAIJAN_C = new Language("Cy-az AZ", "Azeri (Cyrillic) Azerbaijan");
            public static Language AZERBAIJAN_L = new Language("Lt-az AZ", "Azeri (Latin) - Azerbaijan");
            public static Language BASQUE = new Language("eu-ES", "Basque");
            public static Language BELARUS = new Language("be-BY", "Belarus");
            public static Language BULGARIA = new Language("bg-BG", "Bulgaria");
            public static Language CATALAN = new Language("ca-ES", "Catalan");
            public static Language CHINA = new Language("zh-CN", "China");

            private string bettercode;
            private string simplename;

            private Language(string bettercode, string simplename)
            {
                this.bettercode = bettercode;
                this.simplename = simplename;
                set.Add(this);
            }

            public string getName()
            {
                return simplename;
            }

            public string getLanguageCode()
            {
                return bettercode;
            }

            public Language[] values()
            {
                return set.ToArray();
            }

            public Language valueOf(string name)
            {
                foreach(Language lang in values())
                {
                    if(lang.getName().ToLower().StartsWith(name.ToLower()))
                    {
                        return lang;
                    }
                }
                return null;
            }
        }

    }
}
