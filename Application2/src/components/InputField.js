import React from 'react';

function InputField({ value, onChange }) {
    return (
        <div className="form-group">
            <label htmlFor="messageInput">Enter Message</label>
            <input 
                type="text" 
                className="form-control" 
                id="messageInput" 
                value={value} 
                onChange={onChange} 
            />
        </div>
    );
}

export default InputField;
