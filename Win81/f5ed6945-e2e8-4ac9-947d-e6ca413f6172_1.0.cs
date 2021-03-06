//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\audiosrv.dll
// Interface ID: f5ed6945-e2e8-4ac9-947d-e6ca413f6172
// Interface Version: 1.0



namespace rpc_f5ed6945_e2e8_4ac9_947d_e6ca413f6172_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("f5ed6945-e2e8-4ac9-947d-e6ca413f6172", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_pbmReportAppInteractivityChange(string p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int s_pbmSendAppCommand(int p0, System.Guid p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteGuid(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            p2 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_pbmSendAppCommandToApp(string p0, int p1, System.Guid p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            m.WriteGuid(p2);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_RevokeDeviceAccessForPackage(string p0, string p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"));
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int s_pbmRegisterAppManagerNotification()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(4, m);
            return u.ReadInt32();
        }
        public int s_pbmUnregisterAppManagerNotification()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int s_pbmGetActiveMediaApp(out string p0, out string p1, out string p2, out string p3, out int p4, out int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p1 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p2 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p3 = u.ReadReferent<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            p4 = u.ReadInt32();
            p5 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int s_pbmReportAppClosing(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int s_pbmReportHostedAppStateChange(string p0, int p1, ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteInt32(p1);
            m.WriteContextHandle(p2);
            _Unmarshal_Helper u = SendReceive(8, m);
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_SetScreenReaderState(int p0, int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int s_pbmSwitchSoftNonInteractiveAppsToHardNonInteractive()
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(10, m);
            return u.ReadInt32();
        }
        public int s_pbmReportApplicationState(string p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteEnum16(p1);
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

