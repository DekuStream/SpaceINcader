﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Space_Invader_Réparé;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invader_Réparé.Tests
{
    [TestClass()]
    public class InvaderMissileTests
    {
        [TestMethod()]
        public void MoveTest()
        {
            InvaderMissile missile = new InvaderMissile(2,4);

            missile.Move();

            Assert.AreEqual(5,missile.PositionY);
            Assert.AreEqual(2,missile.PositionX);
            
        }
    }
}