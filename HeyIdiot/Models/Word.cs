using System.Collections.Generic;

namespace HeyIdiot.Models
{
  public class Word
  {
    public Word()
    {
    }

    public string Name { get; set; }

    public List<string> Definitions { get; set; }
  }
}
