// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
namespace Microsoft.Protocols.TestTools.StackSdk.FileAccessService.Fscc
{
    /// <summary>
    /// the response packet of FSCTL_DELETE_REPARSE_POINT 
    /// </summary>
    public class FsccFsctlDeleteReparsePointResponsePacket : FsccStandardPacket<FsctlDeleteReparsePointReplyStatus>
    {
        #region Properties

        /// <summary>
        /// the command of fscc packet 
        /// </summary>
        public override uint Command
        {
            get
            {
                return (uint)FsControlCommand.FSCTL_DELETE_REPARSE_POINT;
            }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// default constructor 
        /// </summary>
        public FsccFsctlDeleteReparsePointResponsePacket()
            : base()
        {
        }


        #endregion
    }
}
