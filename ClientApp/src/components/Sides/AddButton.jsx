import React from 'react';

import { FaPlus } from 'react-icons/fa';

const AddButton = ({ handleAdd }) => {
    return(
        <div onClick={handleAdd } className="btn btn-primary float-bottom-right" style={
                {
                    position: 'fixed',
                    bottom: '15px',
                    right: '15px',
                    zIndex: 999,
                    borderRadius: '50%',
                    width: '50px',
                    height: '50px',
                    display: 'flex',
                    justifyContent: 'center',
                    alignItems: 'center'
                }
            }  title="Ajouter projet">
            <FaPlus></FaPlus>
        </div>
    );
}

export default AddButton;