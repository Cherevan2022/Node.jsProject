import { Route, Routes } from 'react-router-dom';
import { DefaultLayout } from './components/DefaultLayout';
import Home from './components/Home';
import { NotFound } from './components/NotFound';
import { ComputerInfo } from './components/ComputerInfo';
import { About } from './components/About';


export const App = () => {
    return (
        <>
            <Routes>
                <Route path="/" element={<DefaultLayout/>}>
                    <Route index element={<Home/>}></Route>
                    <Route path="*" element={<NotFound/>}></Route>
                    <Route path="/about" element={<About/>}></Route>
                    <Route path="computer/:id" element={<ComputerInfo/>}></Route>
                </Route>
            </Routes>
        </>
    );
};
