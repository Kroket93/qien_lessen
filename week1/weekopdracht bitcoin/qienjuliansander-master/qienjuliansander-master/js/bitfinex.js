function messageHandler(event) {
    self.postMessage("Received: " + event.data);
}
self.addEventListener("message", messageHandler, false);

//

const socket = new WebSocket('wss://api-pub.bitfinex.com/ws/2')

// w.on('message', (msg) => console.log(msg))

// let msg = JSON.stringify({ 
//   event: 'subscribe', 
//   channel: 'ticker', 
//   symbol: 'tBTCUSD' 
// })

// w.on('open', () => w.send(msg))

// //


// const socket = new WebSocket('wss://ws.cex.io/ws/')

socket.onopen = function() {
    console.log ("Connection to server now open");
    console.log("BITFINEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEX")

    const message = {
        event: "subscribe",
        channel: 'ticker',
        symbol: 'tBTCUSD'
    }
    socket.send(JSON.stringify(message))
}

socket.onmessage = function(event) {
    console.log(event.data);
    const reply = {
        exchange: "bitfinex",
        data: event.data
    }
    self.postMessage(reply);
}

socket.onclose = function(event) {
    console.log('Connection closed');
}