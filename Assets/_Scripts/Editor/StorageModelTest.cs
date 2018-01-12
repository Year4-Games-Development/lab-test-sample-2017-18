using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class StorageModelTest {
	//- units is 0
	[Test]
	public void Test_Get_Units() {
		//arrange
		StorageModel storageModel = new StorageModel ();
		int expectedResult = 0;

		//act
		int result = storageModel.GetUnits();

		//assert
		Assert.AreEqual(result,expectedResult);
	}
	//- capacity is 100
	[Test]
	public void Test_Get_The_Capacity(){
		//arrange
		StorageModel storageModel = new StorageModel();
		float expectedResult = 100.0f;

		//act
		int result = storageModel.Capacity;

		//assert
		Assert.AreEqual(result, expectedResult);
	}
	//- maxDelivery is 20
	[Test]
	public void Test_Max_Delivery(){
		//arrange
		StorageModel storageModel = new StorageModel();
		int expectedResult = 20;

		//act 
		int result = storageModel.MaxDelivery;

		//assert
		Assert.AreEqual(result, expectedResult);
	}
	//- nearlyFullLoadPercdentage is .75
	[Test]
	public void Test_Nearly_Full_Load_Percentage(){
		//arrange
		StorageModel storageModel = new StorageModel();
		double expectedResult = 0.75;

		//act 
		double result = storageModel.NearlyFullPercentage;

		//assert
		Assert.AreEqual(result, expectedResult);
	}
	//- isNearlyFull() method returns false
	[Test]
	public void Test_Is_Nearly_Full_Method_Should_Return_False(){
		//arrange 
		StorageModel storageModel = new StorageModel();

		//act 
		bool result = storageModel.IsNearlyFull();

		//assert
		Assert.False(result);
	}

	//- test that after one delivery of 10, the delivery method returns false and the number of units is 10
	[Test]
	public void Test_After_One_Delivery_Of_10_Method_Returns_False_And_Units_10(){
		//arrange
		StorageModel storageModel = new StorageModel ();
		int deliveryQuantity = 10; 
		int expectedDelivery = 10;

		//act
		bool deliverySuccess = storageModel.Deliver(deliveryQuantity);
		int result = storageModel.GetUnits ();

		//assert 
		Assert.True(deliverySuccess);
		Assert.AreEqual (result, expectedDelivery);
	}

	//- test that after one delivery of 25, the delivery method returns false and number of units is still 0
	[Test]
	public void Test_After_One_Delivery_Of_25_Method_Returns_False_And_Units_Still_0(){
		//arrange 
		StorageModel storageModel = new StorageModel();
		int deliveryQuantity = 25;
		int expectedDelivery = 0;

		//act
		bool deliverySuccess = storageModel.Deliver(deliveryQuantity);
		int result = storageModel.GetUnits();

		//assert
		Assert.False(deliverySuccess);
		Assert.AreEqual(result, expectedDelivery);
	}
	//- test that after four deliveries of 20, the isNearlyFull() method returns true and number of units is 80
	[Test]
	public void Test_After_four_Delivery_Of_20_IsnNearlyFUll_Method_Returns_true_And_Units_80(){
		//arrange
		StorageModel storageModel = new StorageModel();
		int deliveryQty = 20;

		int expectedUnits = 80;

		//act
		bool deliverySuccess1 = storageModel.Deliver (deliveryQty);
		bool deliverySuccess2 = storageModel.Deliver (deliveryQty);
		bool deliverySuccess3 = storageModel.Deliver (deliveryQty);
		bool deliverySuccess4 = storageModel.Deliver (deliveryQty);
		bool success_isNearlyFull = storageModel.IsNearlyFull();
		int result = storageModel.GetUnits ();

		//assert
		Assert.False(success_isNearlyFull);
		Assert.AreEqual (result, expectedUnits);

	}

}