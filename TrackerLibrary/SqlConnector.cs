﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO Make the Create Prize method actually svae to the database
        /// <summary>
        /// Saves the new Prize to the database
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The Prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
