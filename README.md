# Armenian Translit Translator Application
# C#6.0  .NET FRAMEWORK 4.6
----

### Test and Result

![gif source](https://github.com/shtigran/TranslitTranslatorApplication/blob/master/TranslitTranslator.gif)

### Purpose
Many Armenians in the World aren't able to understand Armenian letters and armenian text. Many of them know Armenian language, but don't know letters. This program allow inpute armenian text file and translate it into Armenian translit and save it in another output file, in order to that who knows the Armenian language, but doesn't know the Armenian letters can read the text.

----

### ReplaceArm class implementation

```c#
public static class ReplaceArm
{

    public static string ReplaceArmText(this string text)
  {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Dictionary<string, string> database = new Dictionary<string, string>();
      database.Add("ա", "a");
      database.Add("բ", "b");
      database.Add("գ", "g");
      database.Add("դ", "d");
      database.Add("ե", "e");
      database.Add("զ", "z");
      database.Add("է", "e");
      database.Add("ը", "@");
      database.Add("թ", "t");
      database.Add("ժ", "dj");
      database.Add("ի", "i");
      database.Add("լ", "l");
      database.Add("խ", "kh");
      database.Add("ծ", "ts");
      database.Add("կ", "k");
      database.Add("հ", "h");
      database.Add("ձ", "dz");
      database.Add("ղ", "gh");
      database.Add("ճ", "tc");
      database.Add("մ", "m");
      database.Add("յ", "y");
      database.Add("ն", "n");
      database.Add("շ", "sh");
      database.Add("ո", "o");
      database.Add("չ", "ch");
      database.Add("պ", "p");
      database.Add("ջ", "j");
      database.Add("ռ", "r");
      database.Add("ս", "s");
      database.Add("վ", "v");
      database.Add("տ", "t");
      database.Add("ր", "r");
      database.Add("ց", "c");
      database.Add("ու", "u");
      database.Add("փ", "ph");
      database.Add("ք", "q");
      database.Add("և", "ev");
      database.Add("օ", "o");
      database.Add("ֆ", "f");

      string result = "";
      bool flag = false;
      for (int i = 0; i < text.Length; i++)
    {
        if (i < text.Length-1)
      {
          if (text[i] == 'ո' && text[i + 1] == 'ւ')
        { result += "u";
            i++;
            continue;
        }
      }

        if(char.ToLower(text[i]) <='z' && char.ToLower(text[i]) >= 'a')
      {
          result += text[i].ToString();
          continue;
      }
       if (text[i].ToString() == "\n")
      {
          result += "\r\n";
          continue;
      }
        if (char.IsNumber(text[i]) || char.IsPunctuation(text[i]) || char.IsWhiteSpace(text[i]))
      {
          result += text[i].ToString();
          continue;
      }

        if (char.IsUpper(text[i]))
          flag = true;
        foreach (KeyValuePair<string, string> key in database)
      {         
          if (text[i].ToString().ToLower() == key.Key && flag == true)
        {
            result += key.Value.ToUpper();
            break;
        }
          if (text[i].ToString() == key.Key)
        {
            result += key.Value;
            break;
        }            
      }

        flag = false;
    }
            
      return result;
  }
}
```

### Description of ReplaceArm class
This class allow You translate Armenian text into translit. It takes the text and return translit text.

----

### Program class implementation 
This part take the location path of the file and copy the text into the string. The the method ReplaceArmText() of ReplaceArm class take it convert into translit and return to program. Then the program create the file and copy there the method returned text.
