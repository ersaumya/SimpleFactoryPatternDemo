# SimpleFactoryPatternDemo
Simple factory design pattern  implementation in c#
# Advantages:

1.Centralize the object creation ,i.e Factory helps to create all object creation in one place and avoid creating new keyword across codebase,Hence encapsulate the object creation.Here client is not responsible of object creation,the creation logic is handle by the factory.

2.Enhances scalability and testability of application,as the client code only refers to interface and we can add more product implementing the interface without making any change to client code.As we uses interface so interface heip us to mocking object which helps for testing.

3.Code is more maintainable.

4.Code adhere to SOLID principles.
