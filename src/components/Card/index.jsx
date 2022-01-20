import { Link } from "react-router-dom";
import './index.css';


export const Card = ({ card }) => {

  return (
      <div className="col-3 card mb-3 gap-3 p-4">
        <div className="align-items-stretch">
          <h3 className="card-header">{card.producer}</h3>
          <div className="card-body">
            <h5 className="card-title">{card.model}</h5>
          </div>
          <Link to={`/computer/${card.id}`}>
          <img className="w-100 p-3" src={card.image} alt="image"></img></Link>
          <div className="card-body">
            <p className="card-text">{card.description}</p>
          </div>
          <ul className="list-group list-group-flush">
            <li className="list-group-item">
              {card.cpu.brand} {card.cpu.coresCount}
            </li>
            <li className="list-group-item">
              {card.gpu.brand} {card.gpu.size} MB
            </li>
            <li className="list-group-item">
              {card.ram.generation} {card.ram.size} MB
            </li>
          </ul>
          <div className="card-body">
              
            <a href="#" className="card-link read-more">
            <Link to={`/computer/${card.id}`}>Info</Link>
            </a>
          </div>
        </div>
      </div>
  );
};
