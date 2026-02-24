
//*************************************** START OF FILE ******************************//

//---------------- START OF IMPORTS -----------------//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------- END OF IMPORTS -------------------//
namespace simpleSnakeGame
{
    /// <summary>
    ///  This enum defines the four states a cell can be in.
    /// Empty, occupied by the snake, containing food or outside the playable area 
    /// </summary>
    public enum GridValue
    {
        Empty, Snake, Food, Outside 
    }
}
//****************************************** END OF FILE ***************************// 