using Tensorflow.Keras.Engine;
using Tensorflow.NumPy;
using Tensorflow.Keras.Engine;
using Tensorflow.Keras.Layers;
using static Tensorflow.Binding;
using static Tensorflow.KerasApi;
using Tensorflow;
using Tensorflow.NumPy;
using Tensorflow.Keras.Utils;
using System.Text;
using Tensorflow.Keras;

namespace LogoRecognitionSystem
{
    public class CNN
    {

        ILayer Conv2D_1_;
        ILayer Conv2D_2_;
        ILayer MaxPooling2D_1_;
        ILayer Dropout_1_;
        ILayer Conv2D_3_;
        ILayer Conv2D_4_;
        ILayer MaxPooling2D_2_;
        ILayer Dropout_2_;
        ILayer Conv2D_5_;
        ILayer Conv2D_6_;
        ILayer MaxPooling2D_3_;
        ILayer Dropout_3_;
        ILayer Flatten;
        ILayer Dense_1_;
        ILayer Dense_2_;
        ILayer Dense_3_;

        int outputCount;

        public CNN(int outputCount) {

            var layers = new LayersApi();

            Conv2D_1_ = layers.Conv2D(32, (3, 3), activation: "relu", padding: "same");

            Conv2D_2_ = layers.Conv2D(32, (3, 3), activation: "relu", padding: "same");

            Conv2D_3_ = layers.Conv2D(64, (3, 3), activation: "relu", padding: "same");

            Conv2D_4_ = layers.Conv2D(64, (3, 3), activation: "relu", padding: "same");

            Conv2D_5_ = layers.Conv2D(128, (3, 3), activation: "relu", padding: "same");

            Conv2D_6_ = layers.Conv2D(128, (3, 3), activation: "relu", padding: "same");

            MaxPooling2D_1_ = layers.MaxPooling2D(pool_size: (2, 2));

            MaxPooling2D_2_ = layers.MaxPooling2D(pool_size: (2, 2));

            MaxPooling2D_3_ = layers.MaxPooling2D(pool_size: (2, 2));

            Dropout_1_ = layers.Dropout(0.25f);

            Dropout_2_ = layers.Dropout(0.25f);

            Dropout_3_ = layers.Dropout(0.25f);

            Flatten = layers.Flatten();

            Dense_1_ = layers.Dense(256, activation: "relu");

            Dense_2_ = layers.Dense(128, activation: "relu");

            Dense_3_ = layers.Dense(outputCount, activation: "softmax");


        }

        public Model Build(string name)
        {
            var inputs = keras.Input(shape: (32, 32, 3), name: "img_"+name);

           var  x = Conv2D_1_.Apply(inputs);
                x = Conv2D_2_.Apply(x);
                x = MaxPooling2D_1_.Apply(x);
                x = Dropout_1_.Apply(x);
                x = Conv2D_3_.Apply(x);
                x = Conv2D_4_.Apply(x);
                x = MaxPooling2D_2_.Apply(x);
                x = Dropout_2_.Apply(x);
                x = Conv2D_5_.Apply(x);
                x = Conv2D_6_.Apply(x);
                x = MaxPooling2D_3_.Apply(x);
                x = Dropout_3_.Apply(x);
                x = Flatten.Apply(x);
                x = Dense_1_.Apply(x);
                x = Dense_2_.Apply(x);
       
            return keras.Model(inputs, Dense_3_.Apply(x), name: name); 

        }

        

    }
}
