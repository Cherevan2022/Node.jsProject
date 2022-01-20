import { useParams, useNavigate, Link } from "react-router-dom";
import { useEffect, useState } from "react";
import axios from "axios";
import { Input } from "../Input";
import "./index.css";

export const ComputerInfo = () => {
  const { id } = useParams();
  const navigate = useNavigate();
  const [card, setCard] = useState();
  useEffect(() => {
    if (id) {
      axios
        .get("https://localhost:44323/api/computers/" + id)
        .then((res) => {
          setCard(res.data);
        })
        .catch((err) => {
          console.log(err);
        });
    } else {
      navigate("/not-found");
    }
  }, [id]);
  if (!card) return <></>;
  return (
    <>
      <div className="container">
        <div className="row">
          <div className="col-12">
            <img
              className="rounded mx-auto d-block w-img"
              src={card.image}
              alt="image"
            ></img>
          </div>
        </div>
        <div className="row">
          <div className="col-6 text-center">Model</div>
          <div className="col-6">
            <Input text={card.model}></Input>
          </div>
        </div>
        <div className="row">
          <div className="col-6 text-center">Producer</div>
          <div className="col-6">
            <Input text={card.producer}></Input>
          </div>
        </div>
        <div className="row">
          <div className="col-6 text-center">Description</div>
          <div className="col-6">
          <textarea className="form-control" id="exampleTextarea" placeholder={card.description} value="" rows="3"></textarea>
          </div>
        </div>
        <div className="row">
          <div className="col-6 text-center">CPU</div>
          <div className="col-6">
            <Input text={`${card.cpu.brand} ${card.cpu.coresCount}`}></Input>
          </div>
        </div>
        <div className="row">
          <div className="col-6 text-center">GPU</div>
          <div className="col-6">
            <Input text={`${card.gpu.brand} ${card.gpu.size} MB`}></Input>
          </div>
        </div>
        <div className="row">
          <div className="col-6 text-center">RAM</div>
          <div className="col-6">
          <Input text={`${card.ram.generation} ${card.ram.size} MB`}></Input>
          </div>
        </div>

        <div className="row">
            <div className="col-12 w-100">
      <Link to="/">
        <button type="button" class="btn btn-outline-primary w-100">
          Back to menu
        </button>
      </Link>
      </div>
        </div>
      </div>
    </>
  );
};
