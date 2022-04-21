module Program

open Pulumi

let infra () =
  let provider1 = Kubernetes.Provider(
    "provider1",
    args = Kubernetes.ProviderArgs()
  )

  let provider2 = FSharp.Kubernetes.provider {
    name "provider2"
  }

  dict []

FSharp.Deployment.run infra |> ignore
