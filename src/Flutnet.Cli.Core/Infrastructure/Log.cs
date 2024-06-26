﻿// Copyright (c) 2020-2021 Novagem Solutions S.r.l.
//
// This file is part of Flutnet.
//
// Flutnet is a free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// Flutnet is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY, without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with Flutnet.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace Flutnet.Cli.Core.Infrastructure
{
    internal class Log
    {
        public static void Debug(string text)
        {
            // TODO
            //Console.WriteLine(text);
        }

        public static void Debug(string format, params object[] args)
        {
            // TODO
            //Console.WriteLine(text);
        }

        public static void Ex(Exception e)
        {
            // TODO
            //Console.Error.WriteLine(e);
        }

        public static void Error(string text)
        {
            // TODO
            //Console.Error.WriteLine(text);
        }

        public static void Error(string format, params object[] args)
        {
            // TODO
            //Console.Error.WriteLine(format, args);
        }
    }
}