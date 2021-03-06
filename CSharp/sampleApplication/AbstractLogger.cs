/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AbstractLogger : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AbstractLogger(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AbstractLogger obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AbstractLogger() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ContextModulePINVOKE.delete_AbstractLogger(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual void log(LogLevel level, string message) {
    ContextModulePINVOKE.AbstractLogger_log(swigCPtr, (int)level, message);
    if (ContextModulePINVOKE.SWIGPendingException.Pending) throw ContextModulePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int getLevel(LogLevel level) {
    int ret = ContextModulePINVOKE.AbstractLogger_getLevel(swigCPtr, (int)level);
    return ret;
  }

  public void setLogLevel(LogLevel level) {
    ContextModulePINVOKE.AbstractLogger_setLogLevel(swigCPtr, (int)level);
  }

  public int getLogLevel() {
    int ret = ContextModulePINVOKE.AbstractLogger_getLogLevel(swigCPtr);
    return ret;
  }

  public AbstractLogger() : this(ContextModulePINVOKE.new_AbstractLogger(), true) {
    SwigDirectorConnect();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("log", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateAbstractLogger_0(SwigDirectorlog);
    if (SwigDerivedClassHasMethod("getLevel", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateAbstractLogger_1(SwigDirectorgetLevel);
    ContextModulePINVOKE.AbstractLogger_director_connect(swigCPtr, swigDelegate0, swigDelegate1);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(AbstractLogger));
    return hasDerivedMethod;
  }

  private void SwigDirectorlog(int level, string message) {
    log((LogLevel)level, message);
  }

  private int SwigDirectorgetLevel(int level) {
    return getLevel((LogLevel)level);
  }

  public delegate void SwigDelegateAbstractLogger_0(int level, string message);
  public delegate int SwigDelegateAbstractLogger_1(int level);

  private SwigDelegateAbstractLogger_0 swigDelegate0;
  private SwigDelegateAbstractLogger_1 swigDelegate1;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(LogLevel), typeof(string) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(LogLevel) };
}
