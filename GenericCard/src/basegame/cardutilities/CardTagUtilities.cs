using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenericCard.src.basegame.cardsystem;

namespace GenericCard.src.basegame.cardutilities
{
    public static class CardTagUtilities
    {
        public static string AddCardTag(CardTag input_tag, string tag_list)
        {
            if(IsEmptyTagList(tag_list))
                return input_tag.ToString();
            if(CardHasTag(input_tag, tag_list))
                return taglist;
            return tag_list + ":" + input_tag.ToString();
        }

        public static string RemoveCardTag(CardTag input_tag, string tag_list)
        {
            if(CardHasTag(input_tag, tag_list))
            {
                string[] tags = GetArrayOfTags(tag_list);
                string tag_as_string = input_tag.ToString();
                for(int i = 0; i < tags.Length; i++)
                {
                    if(tags[i] == tag_as_string)
                        tags[i] = "";
                }
                tag_list = "";
                for(int i = 0; i < tags.Length; i++)
                {
                    if(tags[i] == "")
                        continue;
                    else if(tag_list == "")
                        tag_list += tags[i];
                    else
                        tag_list += ":" + tags[i];
                }
            }
            return tag_list;

        }

        public static bool CardHasTag(CardTag input_tag, string tag_list)
        {
            if(IsEmptyTagList(tag_list))
                return false;
            string[] tags = GetArrayOfTags(tag_list);
            string tag_as_string = input_tag.ToString();
            for(int i = 0; i < tags.Length(); i++)
            {
                if(tags[i] == tag_as_string)
                    return true;
            }
            return false;
        }
        
        public static bool IsEmptyTagList(string tag_list)
        {
            return tag_list == "";
        }

        public statric string[] GetArrayOfTags(string tag_list)
        {
            return tag_list.Split(':');
        }
    }
}