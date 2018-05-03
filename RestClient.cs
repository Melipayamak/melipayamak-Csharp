//
//  RestClient.swift
//  MeliPayamak
//
//  Created by Amirhossein Mehrvarzi on 4/25/18.
//  Copyright © 2018 MeliPayamak. All rights reserved.
//

import Foundation

class RestClient : NSObject, NSURLConnectionDelegate, NSURLConnectionDataDelegate
{
    var mutableData:NSMutableData  = NSMutableData()
    
    let endpoint: String  = "https://rest.payamak-panel.com/api/SendSMS/"
    let sendOp: String = "SendSMS"
    
    let getDeliveryOp: String = "GetDeliveries2"
    let getMessagesOp: String = "GetMessages"
    let getCreditOp: String = "GetCredit"
    let getBasePriceOp: String = "GetBasePrice"
    let getUserNumbersOp: String = "GetUserNumbers"
    
    let UserName: String;
    let Password: String;
    
    init(user: String, pass: String){
        self.UserName = user
        self.Password = pass
    }
    
    func Send(to: String, from: String, message: String, isflash: Bool)
    {

    let values = "username=\(self.UserName)&password=\(self.Password)&to=\(to)&from=\(from)&text=\(message)&isFlash=\(isflash.description)"
    
    let url = URL(string: endpoint + sendOp)
    
    let theRequest = NSMutableURLRequest(url: url!)
    
    theRequest.addValue("application/x-www-form-urlencoded; charset=utf-8", forHTTPHeaderField: "Content-Type")
    
    theRequest.httpMethod = "POST"
    theRequest.httpBody = values.data(using: String.Encoding.utf8, allowLossyConversion: false)
    let connection = NSURLConnection(request: theRequest as URLRequest, delegate: self, startImmediately: true)
    
    connection!.start()

    }


    func GetDelivery(Int32 recid)
    {

    let values = "username=\(self.UserName)&password=\(self.Password)&recID=\(recid)"
    
    let url = URL(string: endpoint + getDeliveryOp)
    
    let theRequest = NSMutableURLRequest(url: url!)
    
    theRequest.addValue("application/x-www-form-urlencoded; charset=utf-8", forHTTPHeaderField: "Content-Type")
    
    theRequest.httpMethod = "POST"
    theRequest.httpBody = values.data(using: String.Encoding.utf8, allowLossyConversion: false)
    let connection = NSURLConnection(request: theRequest as URLRequest, delegate: self, startImmediately: true)
    
    connection!.start()

    }
    
    //
    func GetMessages(Int location, String from, String index, Int count)
    {

    let values = "username=\(self.UserName)&password=\(self.Password)&Location=\(location)&From=\(from)&Index=\(index)&Count=\(count)"
    
    let url = URL(string: endpoint + getMessagesOp)
    
    let theRequest = NSMutableURLRequest(url: url!)
    
    theRequest.addValue("application/x-www-form-urlencoded; charset=utf-8", forHTTPHeaderField: "Content-Type")
    
    theRequest.httpMethod = "POST"
    theRequest.httpBody = values.data(using: String.Encoding.utf8, allowLossyConversion: false)
    let connection = NSURLConnection(request: theRequest as URLRequest, delegate: self, startImmediately: true)
    
    connection!.start()

    }

    func GetCredit()
    {

    let values = "username=\(self.UserName)&password=\(self.Password)"
    
    let url = URL(string: endpoint + getCreditOp)
    
    let theRequest = NSMutableURLRequest(url: url!)
    
    theRequest.addValue("application/x-www-form-urlencoded; charset=utf-8", forHTTPHeaderField: "Content-Type")
    
    theRequest.httpMethod = "POST"
    theRequest.httpBody = values.data(using: String.Encoding.utf8, allowLossyConversion: false)
    let connection = NSURLConnection(request: theRequest as URLRequest, delegate: self, startImmediately: true)
    
    connection!.start()

    }

    func GetBasePrice()
    {

    let values = "username=\(self.UserName)&password=\(self.Password)"
    
    let url = URL(string: endpoint + getBasePriceOp)
    
    let theRequest = NSMutableURLRequest(url: url!)
    
    theRequest.addValue("application/x-www-form-urlencoded; charset=utf-8", forHTTPHeaderField: "Content-Type")
    
    theRequest.httpMethod = "POST"
    theRequest.httpBody = values.data(using: String.Encoding.utf8, allowLossyConversion: false)
    let connection = NSURLConnection(request: theRequest as URLRequest, delegate: self, startImmediately: true)
    
    connection!.start()

    }

    func GetUserNumbers()
    {

    let values = "username=\(self.UserName)&password=\(self.Password)"
    
    let url = URL(string: endpoint + getUserNumbersOp)
    
    let theRequest = NSMutableURLRequest(url: url!)
    
    theRequest.addValue("application/x-www-form-urlencoded; charset=utf-8", forHTTPHeaderField: "Content-Type")
    
    theRequest.httpMethod = "POST"
    theRequest.httpBody = values.data(using: String.Encoding.utf8, allowLossyConversion: false)
    let connection = NSURLConnection(request: theRequest as URLRequest, delegate: self, startImmediately: true)
    
    connection!.start()

    }



    
    // NSURLConnectionDelegate
    
    func connection(_ connection: NSURLConnection, didFailWithError error: Error) {
        print("connection error = \(error)")
    }
    
    func connection(_ connection: NSURLConnection, didReceive response: URLResponse) {
        mutableData = NSMutableData()
    }
    
    
    func connection(_ connection: NSURLConnection, didReceive data: Data) {
        self.mutableData.append(data)
    }
    
    
    func connectionDidFinishLoading(_ connection: NSURLConnection) {
       
        let response : RestResponse = RestResponse(mutableData: mutableData)
        print("status is : \(response.StrRetStatus)")
       
    }
    
    
}


//response class
class RestResponse : NSObject
{
    var Value: String = ""
    var RetStatus: String = ""
    var StrRetStatus: String = ""
    
    
    init(mutableData: NSData) {
        super.init()
        
        let JSONDictionary = try? JSONSerialization.jsonObject(with: mutableData as Data, options: []) as! Dictionary<String, AnyObject>
        
        // Loop
        for (key, value) in JSONDictionary! {
            let keyName = key as String
            
            let keyValue: String = String(describing: value)
            
            // If property exists
            if (self.responds(to: NSSelectorFromString(keyName))) {
                self.setValue(keyValue, forKey: keyName)
            }
        }
        // Or you can do it with using
        // self.setValuesForKeysWithDictionary(JSONDictionary)
        // instead of loop method above
    }
    
    
}
