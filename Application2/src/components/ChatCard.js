import React from 'react';
import InputField from './InputField';
import OutputField from './OutputField';

function ChatCard({ inputValue, outputMessage, handleInputChange }) {
    return (
        <div className="card">
            <div className="card-header">
                <h3>React SignalR Chat</h3>
            </div>
            <div className="card-body">
                <InputField value={inputValue} onChange={handleInputChange} />
                <OutputField message={outputMessage} />
            </div>
        </div>
    );
}

export default ChatCard;
