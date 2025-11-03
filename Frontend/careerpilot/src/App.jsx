import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "./pages/Home";
import TestApi from "./pages/TestApi";

export default function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<TestApi />} />
      </Routes>
    </BrowserRouter>
  );
}
