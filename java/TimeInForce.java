/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public final class TimeInForce {
  public final static TimeInForce TimeInForce_DAY = new TimeInForce("TimeInForce_DAY");
  public final static TimeInForce TimeInForce_IOC = new TimeInForce("TimeInForce_IOC");
  public final static TimeInForce TimeInForce_MAX = new TimeInForce("TimeInForce_MAX");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static TimeInForce swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + TimeInForce.class + " with value " + swigValue);
  }

  private TimeInForce(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private TimeInForce(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private TimeInForce(String swigName, TimeInForce swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static TimeInForce[] swigValues = { TimeInForce_DAY, TimeInForce_IOC, TimeInForce_MAX };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

