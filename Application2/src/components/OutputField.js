import React from 'react';

function OutputField({ message }) {
    return (
        <div className="form-group mt-3">
            <label>Output</label>
            <div className="alert alert-secondary">
                {message}
            </div>
        </div>
    );
}

export default OutputField;
