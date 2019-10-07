namespace Madlib.Models
{
  public class MadlibVariable
  {
      public string Noun { get; set;}
      public string Verb {get; set; }
      public string Adjective { get; set; }
      public string Adverb {get; set;}
      public string Exclamation {get; set;}
 
  
   public MadlibVariable (string noun, string verb, string adverb, string adjective, string exclamation) 
   {
       Noun = noun;
       Verb = verb;
       Adjective = adjective;
       Adverb = adverb;
       Exclamation = exclamation;
   }
   public MadlibVariable(string verb, string adjective)
   {
        Verb = verb;
       Adjective = adjective;

   }
  }

}