using System;
using System.Linq;
using System.Collections.Generic;


static void Main () {

List<string> insults = new List<string> {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
};

for (int i=0; i < 3; i++) {
    int randomValue = getRandomInt();
    string index = insults[randomValue];
    Console.WriteLine(index);
    Console.WriteLine();
  }

  int getRandomInt()
{
    int randomVal = new Random().Next(1, 7);
    return randomVal;
}

}
Main();




