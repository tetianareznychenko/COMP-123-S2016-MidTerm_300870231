﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_MidTermExam_300870231
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        public void GenerateLottoNumbers()
        {
            throw new System.NotImplementedException();
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
    }
}