using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam_300870231
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // CREATE private fields here --------------------------------------------        
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private int _setSize;
        private Random _random;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------
        public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }
        }

        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }
            set
            {
                this._elementNumber = value;
            }
        }
        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }
        }
        public Random random
        {
            get
            {
                return this._random;
            }
        }
        public int SetSize
        {
            get
            {
                return this._setSize;
            }
            set
            {
                this._setSize = value;
            }
        }


        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------
        /**
 * <summary>
 * This method will	instantiate new objects	for	the	private	fields _numberList,	_elementList and _random
 * </summary>
 * 
 * @return {void}
 */
        private void _initialize()
        {
            List<int> _numberList = new List<int>();
            List<int> _elementList = new List<int>();
            Random _random = new Random();
        }

        // CREATE the private _build method here -----------------------------------
        /**
 * <summary>
 * This method 	add Integer	Literals	from	1	to	SetSize to	the	read-only
NumberList property
 * </summary>
 * 
 * @return {void}
 */
        private void _build()
        {
            for (int index = 1; index < SetSize; index++)
            {
                NumberList.Add(index);
            }

        }

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }


        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
        /**
 * <summary>
 * This method 	randomly	Select and	Remove numbers	from	the
read-only NumberList property and Add	them	to	the read-only ElementList property.
 * </summary>
 * 
 * @return {void}
 * @param {int} pickedNumber
 */
        public void PickElements()
        {
            if (ElementList.Count > 0)
            {
                NumberList.Clear();
                ElementList.Clear();
                this._build();
            }

            for (int pickedNumber = 0; pickedNumber < random.Next(0, NumberList.Count); pickedNumber++)
            {
                ElementList.Add(NumberList[pickedNumber]);
                NumberList.RemoveAt(ElementList[pickedNumber]);
            }
            ElementList.Sort();
        }
    }
}



