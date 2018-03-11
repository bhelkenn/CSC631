using UnityEngine;

using System;
using System.Collections.Generic;

public class RequestLogin : NetworkRequest {
	public Dictionary<string, string> user = new Dictionary<string, string>();
	public RequestLogin() {
		request_id = Constants.CMSG_AUTH;
		user.Add ("bhelkenn", "Anubis21");
	}
	
	public void send(string username, string password) {
	    packet = new GamePacket(request_id);
		packet.addString(Constants.CLIENT_VERSION);
		packet.addString(username);
		packet.addString(password);
		if (user.TryGetValue (username, out password))
			request_id++;
		else
			Debug.Log ("invalid username/password");
	}
}