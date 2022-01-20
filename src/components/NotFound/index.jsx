import { Link } from "react-router-dom";

export const NotFound = () => {
    return (
        <>
        <div className="container">
            <div className="row">
                <div className="col-12">
                <h1 className="text-center">* - * Nothing was found . . .</h1>
                </div>
                <div className="col-12">
                <Link to="/" className="d-block">
        <button type="button" class="btn btn-outline-primary w-100">
          Back to menu
        </button>
      </Link>
                </div>
            </div>
        </div>
       
        </>
    )
}