﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Model;

namespace ZyGames.Framework.Game.Message
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, "", "SensitiveWord")]
    public class SensitiveWord : ShareEntity
    {

        /// <summary>
        /// </summary>
        public SensitiveWord()
            : base(AccessLevel.ReadOnly)
        {

        }
        /// <summary>
        /// </summary>
        public SensitiveWord(int code)
            : this()
        {
            _code = code;
        }

        #region 自动生成属性
        private int _code;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("Code", IsKey = true)]
        public int Code
        {
            get
            {
                return _code;
            }

        }
        private string _word;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Word")]
        public string Word
        {
            get
            {
                return _word;
            }

        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "Code": return _code;
                    case "Word": return _word;
                    default: throw new ArgumentException(string.Format("SensitiveWord index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "Code":
                        _code = value.ToInt();
                        break;
                    case "Word":
                        _word = value.ToNotNullString();
                        break;
                    default: throw new ArgumentException(string.Format("SensitiveWord index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion


    }
}