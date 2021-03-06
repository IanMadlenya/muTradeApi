/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class TradeBook : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TradeBook(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(TradeBook obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TradeBook() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ContextModulePINVOKE.delete_TradeBook(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_std__listT_mutrade__Trade_p_t getTrades(long clOrderId) {
    IntPtr cPtr = ContextModulePINVOKE.TradeBook_getTrades(swigCPtr, clOrderId);
    SWIGTYPE_p_std__listT_mutrade__Trade_p_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__listT_mutrade__Trade_p_t(cPtr, false);
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TradeQue getTradeQue(long clOrderId) {
    IntPtr cPtr = ContextModulePINVOKE.TradeBook_getTradeQue(swigCPtr, clOrderId);
    TradeQue ret = (cPtr == IntPtr.Zero) ? null : new TradeQue(cPtr, false);
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int update(ExecutionReport report) {
    int ret = ContextModulePINVOKE.TradeBook_update(swigCPtr, ExecutionReport.getCPtr(report));
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TradeBook() : this(ContextModulePINVOKE.new_TradeBook(), true) {
  }

}
