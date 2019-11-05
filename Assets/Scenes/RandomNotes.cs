using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Narration project desired goals
    create a 2d display of scrolling text that gives a stronger feeling the text on the screen,
    aka, instead of just a wall of shitty text popping up I want the text to display at human readable/typeable speeds
    with an accompanying sound to indicate that the words/characters are being written, with a variable rate of expression settable in the narration builder.
    In addition I would like it to have the option for variable sounds AND points that can call delegate functions to indicate certain points in the text have been reached.
    It also needs to be independant enough that it can be used in both unity (and after a c convertsion, used in unreal) with any text displayer that can display unicoded strings
    
*/

// ! in the text is a signifier of special events, !! is how to display a normal !
// Unicode Support
// Character code                       !c<n> (who is delivering this line, independant of voice used) (0 will be reserved for no character/narrator, 1 will be reserved for hidden character)
// Character/Emotional Typing Voices    !v<n> ( any number, should be enumed out by string ) (0 will be reserved for no voice)
// Different Speaking Speeds            !s<n> (1 - 5)
// Triggering of Delegate Events        !d<n> (1 - infinite, also user defined, but by dialog instead of by text block )
// Should also be able to trigger actual voice lines in place of the speaking sounds (extra class wrappers)
// Branching paths on choices,          likely to be accomplished via seperate linked dialogs

// KeyWords
// A Key, primary progression key, not required to be a key, player will press a to progress through text blocks 
// B Key, primary acceleration key, not required to be b key
// Text block -> a single grouping of screen representable text under a dialog parent (one empty to full screen block), player may accelerate the text display speed by pressing b or use a to skip the text draw entirely (1 press to blit all text, 2 to blit and progress)
// Dialog -> a group of 1 or more text blocks, player progresses through text blocks with a and b. wasd to make choices
//  not necissarily a single person or even a complete converstation but points that can be logically linked together to form a dialog net
// Dialog net -> not apart of original document, a secondary structure to handle the transitions between dialogs that have options or alternate paths based on player choice instead of normal game triggers

// Typical use case
// Player walks past a plant with their party
// Dialog where the players party member greg remarks that the plant in question is actually very rare and prized for its healing qualities
// Second player party member gerald responds that they wonder if the plant is actually valuable as it just looks like a weed
// greg remarks that gerald should consider judging things based on their appearance, considering geralds own appearance.
// gerald is at a loss for a reply, ...
// End of dialog, dialog closes and game continues

// Special use case (using dialog net)
// Same as previous case until geralds first remark
// Player queried if they should bother collecting the plant to possibly sell later.
// Player either responds "yes, lets collect it, it might be useful if we can find somone to refine it" or "No, we can't afford to stop to collect plants, we have to keep moving."
// Greg will now respond with either a positive affirmation that he'll start collecting right away or a resigned acceptance that we have to keep moving.
// Gerald will then say his remark which will cause the same reply from greg.
// (In this situaltion the statements before, immediately after, and after the players choice would be seperate dialogs connected together via the dialog net)



public class RandomNotes : MonoBehaviour
{
}
