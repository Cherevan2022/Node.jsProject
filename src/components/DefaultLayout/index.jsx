import { Outlet } from "react-router-dom";
import { Navbar } from "../Navbar";

export const DefaultLayout = () => {
  return (
    <div className="d-flex flex-column min-vh-100">
      <Navbar></Navbar>
      <div className="container d-flex mb-5">
        <Outlet />
      </div>
    </div>
  );
};
