using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageController{

	private StorageModel model;
	private StorageView view;

	private InputField inputFieldDelivery;

	public void SetModel(StorageModel model){
		this.model = model;
	}

	public void SetView(StorageView view){
		this.view = view;
	}

	public void SetInputFieldDelivery(InputField inputFieldDelivery){
		this.inputFieldDelivery = inputFieldDelivery;
	}

	private int GetQuantityFromInputField(){
		string quantityString = inputFieldDelivery.text;

		if (quantityString.Length < 1) {
			quantityString = "0";
		}

		int quantity = int.Parse(quantityString);
		return quantity;
	}

	public void EVENT_Delivery(){
		int quantity = GetQuantityFromInputField ();

		model.Deliver (quantity);
		view.Refresh ();
	}

}
