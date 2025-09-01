import React from 'react'
import './chat.css'

export default function chat() {
  return (
   <>
   <div class="chat-container">
        {/* <!-- Chat header --> */}
        <div class="chat-header">
            <img src="whatsapp_logo.png" alt="WhatsApp Logo"/>
            <h1>WhatsApp</h1>
        </div>
        {/* <!-- Chat messages area --> */}
        <div class="chat-messages">
            {/* <!-- Sample message (You'll dynamically populate these messages using JavaScript) --> */}
            <div class="message">
                <div class="user">John Doe</div>
                <div class="text">Hello there!</div>
            </div>
        </div>
        {/* <!-- Chat input area --> */}
        <div class="chat-input">
            <input type="text" placeholder="Type a message..."/>
            <button>Send</button>
        </div>
    </div>
   </>
  )
}

