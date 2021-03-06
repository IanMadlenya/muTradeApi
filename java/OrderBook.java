/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class OrderBook {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected OrderBook(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(OrderBook obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        ContextModeuleJNI.delete_OrderBook(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public Order getOrder(long clOrderId) {
    long cPtr = ContextModeuleJNI.OrderBook_getOrder(swigCPtr, this, clOrderId);
    return (cPtr == 0) ? null : new Order(cPtr, false);
  }

  public int update(ExecutionReport report, boolean reconcileOldOrders) {
    return ContextModeuleJNI.OrderBook_update__SWIG_0(swigCPtr, this, ExecutionReport.getCPtr(report), report, reconcileOldOrders);
  }

  public int update(ExecutionReport report) {
    return ContextModeuleJNI.OrderBook_update__SWIG_1(swigCPtr, this, ExecutionReport.getCPtr(report), report);
  }

  public void insert(Order order) {
    ContextModeuleJNI.OrderBook_insert(swigCPtr, this, Order.getCPtr(order), order);
  }

  public OrderBook() {
    this(ContextModeuleJNI.new_OrderBook(), true);
  }

}
