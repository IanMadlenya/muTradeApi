/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public final class OrderType {
  public final static OrderType OrderType_LIMIT = new OrderType("OrderType_LIMIT");
  public final static OrderType OrderType_MARKET = new OrderType("OrderType_MARKET");
  public final static OrderType OrderType_STOP_LIMIT = new OrderType("OrderType_STOP_LIMIT");
  public final static OrderType OrderType_STOP = new OrderType("OrderType_STOP");
  public final static OrderType OrderType_MAX = new OrderType("OrderType_MAX");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static OrderType swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + OrderType.class + " with value " + swigValue);
  }

  private OrderType(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private OrderType(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private OrderType(String swigName, OrderType swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static OrderType[] swigValues = { OrderType_LIMIT, OrderType_MARKET, OrderType_STOP_LIMIT, OrderType_STOP, OrderType_MAX };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

