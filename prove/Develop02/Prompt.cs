public class Prompt
{
    public List<string> _promptList = new List<string>();


    //store a list of prompts, clear them, and retrieve a random prompt from the list
    public void FillPromptList()
    {
        /*It clears the _promptList to remove any existing prompts.
        This is done to ensure that the list is empty before adding new prompts to it.*/
        _promptList.Clear();

        //list of prompts:

        _promptList.Add("Hmm...this guy today was just mind-blowing: ");
        _promptList.Add("This event today made me feel like I'm in Heaven: ");
        _promptList.Add("This made me feel as though I'm Jared's brother! 'Seeing The Lord's finger: '");
        _promptList.Add("Something that really evoked feelings inside me: ");
        _promptList.Add("Yeah, I really screwed up that one thing. Needs some introspection and redoing: ");
        _promptList.Add("Guess, what, I'm actually greatful for something today and it's: ");
        _promptList.Add("I didn't just whine through out the day. I helped this guy: ");
    }

    //getting a random prompt from the list    
    public string GetRandomPrompt()
    {
        FillPromptList();

        Random random = new Random();
        /*a random integer called randomPromptNumber is generated using the Next method of the Random class.
        This integer will be used as an index to select a random prompt from _promptList*/
        int randomPromptNumber = random.Next(0, _promptList.Count);

        return _promptList[randomPromptNumber];
    }
}