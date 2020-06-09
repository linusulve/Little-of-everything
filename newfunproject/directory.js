const express = require('express')
const logger = require('morgan')
const errorhandler = require('errorhandler')
const bodyparser = require('body-parser')

let store = ()
store.accounts = []

let app = express()
app.use(bodyParser.json())
app.use(logger('dev'))
app.use(errorhandler())

import android.content.Context;

import edu.berkeley.telemonitoring.client.serverservices.ClientSideProtocolInterface;
import edu.berkeley.telemonitoring.client.serverservices.ServerHandler;

public class SingletonServerHandler extends ServerHandler {
	static private SingletonServerHandler mSingletonInstance = null; // The sole instance of this class that can exist

	static private int mSingletonTimeInterval = 120 * 1000; // Default of 2 minutes (120,000 milliseconds)
	static private ClientSideProtocolInterface mSingletonServerProtocol = null;

	/**
	 * Constructor is private to ensure that it is only ever called internally if no instance
	 * exists yet.
	 * @param context
	 * @param protocol
	 * @param time
	 */
	private SingletonServerHandler(Context context, ClientSideProtocolInterface protocol, int time) {
		super(context, protocol, time);
	}

	/**
	 * Must be called before the first call of getInstance.
	 * Subsequent calls after the first call of getInstance do nothing.
	 * @param protocol
	 */
	static public void setProtocol(ClientSideProtocolInterface protocol) {
		if (mSingletonInstance == null) {
			mSingletonServerProtocol = protocol;
		}
	}

	/**
	 * Must be called before the first call of getInstance.
	 * Can be called later to change the time interval.
	 * @param time
	 */
	static public void setTimeInterval(int time) {
		mSingletonTimeInterval = time;

		if (mSingletonInstance != null) {
			mSingletonInstance.setSyncRate(time);
		}
	}

	/**
	 * Returns the sole instance of SingletonServerHandler.
	 * Will instantiate a new one if it doesn't yet exist,
	 * and only if the time interval and protocol have been configured.
	 * @param context
	 * @return The singleton instance
	 */
	static public SingletonServerHandler getInstance(Context context) throws ServerHandlerException {
		if (mSingletonInstance == null) {
			if (mSingletonServerProtocol != null) {
				mSingletonInstance = new SingletonServerHandler(context, mSingletonServerProtocol, mSingletonTimeInterval);
			} else {
				// Trying to create a new instance without having defined the protocol
				throw new ServerHandlerException("Cannot create instance with an undefined server protocol.");
			}
		}

		return mSingletonInstance;
	}
}
