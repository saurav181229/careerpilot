import { useEffect, useState } from "react";
import api from "../services/api";

export default function TestApi() {
  const [message, setMessage] = useState("Checking connection...");

  useEffect(() => {
    api.get("/api/ping")
      .then(res => setMessage(res.data))
      .catch(err => setMessage(" Connection failed"));
  }, []);

  return (
    <div className="min-h-screen flex flex-col items-center justify-center">
      <h1 className="text-2xl font-bold mb-4">Backend Connection Test</h1>
      <p>{message}</p>
    </div>
  );
}
